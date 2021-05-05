ASFLAGS=--gdwarf-2 -s --64 
LDFLAGS=-static

.PHONY: all clean exec


all: 
	make backdoor

backdoor:
	as $(ASFLAGS) backdoor_asm.s -o backdoor.o
	ld $(LDFLAGS) backdoor.o -o Backdoor

clean: 
	rm -f *.o Backdoor

exec:
	chmod +x Backdoor