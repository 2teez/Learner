# My first program. This is a commet

.globl start

.section _TEXT,_text

start:
    movq $60, %rax
    movq $3, %rdi
    syscall
