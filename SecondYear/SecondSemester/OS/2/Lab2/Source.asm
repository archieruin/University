.686P
.MODEL	 	FLAT, STDCALL
.STACK	 	4096
.DATA
		MB_OK		EQU		0
		m			EQU   	95      		
		str_format  DB   	"X = %d",0
		str_buffer 	DB		256 dup (0)
		m_title		DB		"Lab #2",0
		A			DB      100        		;a = 100
		B			DB     	3      		    ;b = 3
		C1		    DB      2        		;c = 2
		D			DB     	4         		;d = 4
		X			DD      ?

	extern MessageBoxA@16:NEAR
	extern wsprintfA:NEAR
.CODE
Start:
		    xor      eax, eax                   ; ax = 0
			mov      al, B                      ; al = b
			mul      al                         ; al = b ^ 2
			mov      bl, al                     ; bl = al = b ^ 2

			xor      eax, eax                   ; ax = 0
			mov      al, C1                     ; al = c
			mul      al                         ; al = c ^ 2
			mul      bl                         ; ax = b ^ 2 * c ^ 2
			sub      ax, 23d                    ; ax = (b ^ 2 * c ^ 2) - 23
			mov      cx, ax                     ; cx = ax = (b ^ 2 * c ^ 2) - 23  

			xor      eax, eax                   ; ax = 0
			mov      al, D                      ; al = d
			mul      al                         ; al = d ^ 2
			mov      ah, B                      ; ah = b
			sub      al, ah                     ; al = d ^ 2 - b
			mul      A                          ; ax = (d ^ 2 - b) * a          
			cwd
			div      cx                         ; ax = (d ^ 2 - b) * a    /    (b ^ 2 * c ^ 2) - 23                      
			mov      cx, ax                     ; cx = ax = (d ^ 2 - b) * a    /    (b ^ 2 * c ^ 2) - 23  

			xor      eax, eax                   ; ax = 0
			mov      bl, B                      ; bl = b
			cbw
			add      bx, cx                     ; bx = b + (ax = (d ^ 2 - b) * a    /    (b ^ 2 * c ^ 2) - 23)
			cbw
			sub      bx, m                      ; bx = (bx = b + (ax = (d ^ 2 - b) * a    /    (b ^ 2 * c ^ 2) - 23)) - 95

		    MOV     BYTE PTR[X], bl

		    PUSH	X
		    PUSH	OFFSET str_format
		    PUSH	OFFSET str_buffer
		    CALL	wsprintfA
		    ADD	 esp, 12

		    PUSH	MB_OK
		    PUSH	OFFSET m_title
		    PUSH	OFFSET str_buffer
		    PUSH	0
		    CALL	MessageBoxA@16

		    RET
END Start
