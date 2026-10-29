#usando o append

nota = [60,95,80,50,98]
nota.append(20)
print(nota)

#usando o insert 

nota= [60,95,80,50,98]
nota.insert(1,20)
print(nota)

#usando o del
nota=[60,20,95,80,50,98]
del nota [3]
print(nota)

#
livros=["java","sqlserver","delphi","python","android"]
print(livros)
livros.pop() #remove o ultimo item
print(livros)
livros.pop(1) #remove o item na posição 1 (o 2° item)
print(livros)

#tem que dar erro no terceiro pq ele ja removeu os dois "oracle"
livros=["oracle","java","sqlserver","delphi","python","android","oracle"]
print(livros)
livros.remove("oracle") #remove a primeira ocorrencia do item passado no parametro
print(livros)
livros.remove("oracle") #remove o proximo  item passado no parametro 
print(livros)
#livros.remove("oracle") #remove o proximo  item passado no parametro, assim crashando a aplicação
#print(livros)


#
livros = ["oracle","java","sqlserver","delphi","python","android","oracle"]
print(livros)
print(livros.count("python"))
print(livros.count("oracle"))

#