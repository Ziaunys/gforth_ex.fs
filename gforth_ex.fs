\ Milestone 1 exercises
\ Name: Eric Zounes
\ Date: 1/22/12
\ 1. printf("Hello World \n")

." 1." cr
." Hello World" cr
." 2." cr
\ 2. 10 + 7 - 3 * 5 / 12 
.s 10 7 + 3 5 * 12 / -
.s
\ Result: 16
clearstacks
." 3." cr
\ 3. 10.0 + 7.0 - 3.0 * 5.0 / 12.0
f.s 10e 7e f+ 3e 5e f* 12e f/ f- 
2 set-precision f.s
\ Result:
clearstacks
." " cr
." 4." cr
\ 4. 10.0e0 + 7.0e0 - 3.0e0 * 5.0e0 / 12.0e0 
f.s 10e 7e0 f+ 3e0 5e0 f* 12e0 f/ f-
f.s
\ Result: 
clearstacks
." " cr
." 5." cr
\ 5. 10 + 7.0e0 - 3.0e0 * 5 / 12 
.s 10 0 d>f 7e0 f+ 3e0 5 0 d>f f* 12 0 d>f f/ f-
f.s
clearstacks
." " cr
." 6." cr
\ 6. y = 10; x = 7.0e0; y + x - 3.0e0 * 5 / 12 
variable y ( -- n )
10 y ! .s 
fvariable x ( -- n ) 
7e0 x f! f.s
.s y @ .s 0 d>f x f@ f.s f+ 3e0 5 0 d>f f* 12 0 d>f f/ f-
f.s
clearstacks
." " cr
." 7." cr
\ 7. if 5 < 3 then 7 else 2
clearstacks
: comp1 ( n1 n2 -- n )
	2dup < if
		.s 7
		.s
	else
		.s 2
		.s 
	endif ;
3 5 comp1 
clearstacks
." " cr
." 8." cr
\ 8. if 5 > 3 then 7 else 2
: comp2 ( n1 n2 -- n )
        2dup > if
                .s 7
                .s
        else
                .s 2
                .s
        endif ;
3 5 comp2 
clearstacks
.s
." " cr
." 9." cr
\ 9. for ( i = 0; i <= 5; i++ )
\     printf("%d ", i); 
: loop1 ( n1 n2 -- n )
	+do
	i . 
	loop ;
6 0 loop1
.s 
clearstacks
." " cr
." 10." cr
\ 10. double convertint(int x)
." Converts 5 to a double." cr
: convertint1 ( n -- df )
	.s 0 
	2dup d>f f.s
	
;
\ The variable x is the argument for convertint1
variable x ( -- addr )
5 x ! .s 
x @ convertint1 
clearstacks
." " cr
." 11." cr
\ 11. int fact(int i)
\ {
\   if (i <= 0 ) return 1;
\    else return i*fact(i-1);
\ 
: fact ( n -- n! ) recursive 
	dup 0 > if
		dup 1 - fact * 
	else
		drop 1
	endif ; 
." Computes 5!" cr
5 fact .s 
clearstacks
." " cr
." 12." cr
\ 12.  int fib(int i)
\ {
\    if(i == 0) return 0;
\    else if(i == 1) return 1;
\    else return fib(i-1) + fib(i-2);
\ }
." Computes the 9th fibonacci number." cr
: fib ( n1 n2 -- n )
	+do
	2dup + 
	loop ;
\ fib takes (x0,x1, fib#, 0 for range)
.s 0 1 9 0 fib
.s
bye 
