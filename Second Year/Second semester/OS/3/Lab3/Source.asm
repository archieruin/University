.686P
.MODEL FLAT, STDCALL
.STACK 4096
.DATA    	
		a			DD      100        		;a = 100
		b			DD     	3      		    ;b = 3
		c_		    DD      2        		;c = 2
		d			DD     	4         		;d = 4
		x			DD      ?

	message  DB "Lab#3", 0
	STR1	DB 20 DUP(? )
	HW	DD ?
	MB_OK    EQU 0
	EXTERN MessageBoxA@16:NEAR

.CODE
Start:
		xor eax, eax
		xor ebx, ebx
		xor ecx, ecx

		push[a]
		push[b]
		push[c_]
		push[d]

		call Expression
		mov[x], eax
		call PrintNum

		push MB_OK
		push OFFSET message
		push OFFSET STR1
		push HW
		call MessageBoxA@16
		RET

			Expression PROC
					push ebp                        ; збереження вказівника
					mov ebp, esp                    ; передача вказівника на вершину стека 

						xor      eax, eax                   ; ax = 0
						mov      ax, [ebp+16]               ; ax = b
						mul      ax                         ; ax = b ^ 2
						mov      cx, ax                     ; cx = ax = b ^ 2

						xor      eax, eax                   ; ax = 0
						mov      ax, [ebp+12]               ; ax = c
						mul      ax                         ; ax = c ^ 2
						mul      cx                         ; ax = c ^ 2 * b ^ 2
						sub      ax, 23d                    ; ax = (c ^ 2 * b ^ 2) - 23
						mov      cx, ax                     ; cx = ax = (c ^ 2 * b ^ 2) - 23  

						xor      eax, eax                   ; ax = 0
						mov      ax, [ebp+8]                ; ax = d
						mul      ax                         ; ax = d ^ 2
						sub      ax, [ebp+16]               ; ax = d ^ 2 - b
						mov      bx, [ebp+20]               ; bx = a
						mul      bx                         ; dx:ax = (d ^ 2 - b) * a
						div      cx                         ; ax = (d ^ 2 - b) * a / (c ^ 2 * b ^ 2) - 23
						mov      cx, ax                     ; cx = ax = (d ^ 2 - b) * a / (c ^ 2 * b ^ 2) - 23 ---> cx

						xor      eax, eax                   ; ax = 0
					    mov      bx, [ebp+16]               ; bx = b
						add      bx, cx                     ; bx = b + ((d ^ 2 - b) * a / (c ^ 2 * b ^ 2) - 23)
						sub      bx, 95d                    ; bx = b + ((d ^ 2 - b) * a / (c ^ 2 * b ^ 2) - 23) - 95

						mov      ax, bx

				pop ebp ; повернути вказівник на наступний після функції рядок
				RET

			Expression Endp


			PrintNum PROC
					local dk : byte
						mov [dk], 10
						xor ecx, ecx
							M1:
								div [dk]
								add ah, 30h
								push eax
								cbw
								inc ecx
								test al, al
								jnz M1
								xor esi, esi
								xor ebx, ebx
								lea ebx, STR1
							M2:
								pop eax
								mov[ebx], ah
								inc ebx
								loop M2
					RET
				PrintNum Endp
END Start