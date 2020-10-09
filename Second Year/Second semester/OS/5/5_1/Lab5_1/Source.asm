.586
.MODEL FLAT, C
.DATA
.CODE
	Expression PROC C
		push ebp
		mov ebp, esp

			finit
			fld qword ptr[ebp+40]        ;st(0) = 95
			fld qword ptr[ebp+16]        ;st(0) = b   
			fsub st(0), st(1)            ;st(0) = b - 95
			
			fld qword ptr[ebp+16]        ;st(0) = b
			fmul st(0), st(0)            ;st(0) = b ^ 2

			fld qword ptr[ebp+48]        ;st(0) = 23
			fld qword ptr[ebp+24]        ;st(0) = c
			fmul st(0), st(0)            ;st(0) = c ^ 2
			fmul st(0), st(2)            ;st(0) = c ^ 2 * b ^ 2
			fsub st(0), st(1)            ;st(0) = (c ^ 2 * b ^ 2) - 23

			fld qword ptr[ebp+16]        ;st(0) = b
			fld qword ptr[ebp+32]        ;st(0) = d
			fmul st(0), st(0)            ;st(0) = d ^ 2
			fsub st(0), st(1)            ;st(0) = d ^ 2 - b

			fld qword ptr[ebp+8]         ;st(0) = a
			fmul st(0), st(1)            ;st(0) = a * (d ^ 2 - b)
			fdiv st(0), st(3)            ;st(0) = a * (d ^ 2 - b) / (c ^ 2 * b ^ 2) - 23 

			fadd st(0), st(6)            ;st(0) = (a * (d ^ 2 - b) / (c ^ 2 * b ^ 2) - 23) + (b - 95)

		mov esp, ebp
		pop ebp
		RET
	Expression Endp
END
