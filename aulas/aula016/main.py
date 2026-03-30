# nums = [1, 2, 4, 5, 81]

# desaparecido = [x for x in range (min(nums), max(nums)) if not x in nums]

# print(desaparecido)

from random import randint
import re

matriz = [[randint(1, 9) for _ in range(5)] for _ in range(5)]
print(*matriz, sep="\n")

todasAsLetras = r'[\wÁ-ÿ]'