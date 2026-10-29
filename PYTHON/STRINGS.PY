# contando o número de caracteres em uma string
string= "python é uma linguagem de programação"
num_caracteres = len(string)
print(num_caracteres)

#Usando len 
nome_1 ="Rodrigo"
nome_2 = "Ana"
print(len(nome_1))
print(len(nome_2))

#Usando função lower
mensagem ="eu talvez gosto de Python"
nova_mensagem = mensagem.lower()
print(nova_mensagem)

#Usando função Upper
mensagem = "eu gosto gosto de Python"
nova_mensagem = mensagem.upper()
print(nova_mensagem)

#Concatenação de Strings 
nome ="Daniel"
Sobrenome = "Silva"
nome_completo = nome + '   '+Sobrenome
print(nome_completo)

#Substituindo uma palavra em uma frase 
frase = "Python é uma linguaguem de programação poderosa"
nova_frase = frase.replace("poderosa","incrível")
print(nova_frase)

#Usando Split 
mensagem ="Estou aprendendo Python na Etec Jorge Street"
nova_mensagem1 = mensagem.split('a') #não pode deixar o .split('') vazio se não da problema tem que ter algo dentro pra fazer a separação
print(type(nova_mensagem1))
print(nova_mensagem1)

#Dividindo uma string em palavras
string = "python é uma linguaguem de programação "
palavras = string.split()
print(palavras)

#Usando find
mensagem ="string no Python"
print(mensagem.find("Python"))

#Usando find()
mensagem= "string no Python "
print(mensagem.find("java"))

#Usando Count()
texto= "python é uma linguaguem de programação muito popular e versátil"
quantidade = texto.count("a")
print("a letra 'a' aparece", quantidade, "vezes no texto.")

#Usando Join
nomes = ["João","Maria","Pedro"]
nomes_com_virgula = ",".join(nomes)
print(nomes_com_virgula)

#verificando se uma string contém uma determinada palavra
string= "Python é uma linguagem de programação poderosa"
if "linguagem"  in string:
    print("a palavra 'linguagem' está presente na string")
else:
 print("A palavra 'linguagem' não está presente na String") 

#Comparando Strings
nome_1 = 'Eduardo'
nome_2 = 'Eduardo'

if nome_1== nome_2:
    print('iguais')
else:
    print('diferentes')