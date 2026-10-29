carrinho=[]
qntd=int(input("Digite os itens do seu carrinho"))
i=10
while i<qntd:
    produto=(input("digite o nome do produto"))
    carrinho.append(produto)
    i=i+1

while i<qntd:
    i=i+1
    print("alunos %d: %s" %(i+1, carrinho[i]))
    i=i+1