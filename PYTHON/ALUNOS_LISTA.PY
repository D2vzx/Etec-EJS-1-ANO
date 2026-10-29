Alunos = []
qtdAlunos = int(input("Informe a quantidade de alunos na turma: "))

i = 0
while i < qtdAlunos:
    nome = input("Informe o nome do aluno %d: " % (i + 1))
    Alunos.append(nome)
    i += 1
Alunos.sort()

print("\nLista de Alunos (Ordenada)")
i = 0
while i < qtdAlunos:
    print("Aluno %d: %s" % (i + 1, Alunos[i]))
    i += 1

#

lista = []

for i in range(10):
    numero = int(input(f"Digite o {i+1}º número inteiro: "))
    lista.append(numero)

print("Os números digitados foram:")
for item in lista:
    print(item)

print("(min(lista)))
print(max(lista))
print(sum(lista))


