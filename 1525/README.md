1525. Path
Ограничение времени: 1.0 секунды
Ограничение памяти: 64 МБ

A new robot "PTZ07" is now in the testing room. The testing room is a parallelepiped n × m × k. The robot knows a sequence of instructions to execute. The instructions are: 'u' — one position up, 'd' — one position down, 'l' — one position left, 'r' — one position right, 'f' — one position forward, 'b' — one position backward. Robot executes its program one by one. If the instruction tells the robot to go outside the room, the robot ignores this instruction.
You are given a sequence of instructions, but you don't know the initial location of the robot. Your task is to find the number of positions in which the robot may finish its trip.

Исходные данные

The first line of the input contains three integers n, m and k (1 ≤ n, m, k ≤ 105) — width (left-right dimension), height (up-down dimension) and length (forward-backward dimension). The second line contains the sequence of instructions. There will be no more than 105 instructions.

Результат

Output the number of positions where robot may finish its trip after executing the given program.
