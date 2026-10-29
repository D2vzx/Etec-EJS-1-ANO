Esp=(input('Você quer se inscrever em que esporte? (escolha entre: basquete,futebol e vôlei)'))
id=int(input('Qual sua idade?'))
Ge=(input('Qual seu gênero? (masculino ou feminino)'))
if Esp=='basquete'and (11<=id<=16) and Ge=='masculino':
    print('você esta inscrito em basquete')
    if Esp=='futebol'and 14<= id <=16 and (Ge=='masculino'or Ge=='feminino'):
        print('você esta inscrito(a) em futebol')
        if Esp=='vôlei'and (14<=id<=17) and   Ge=='feminino' :
           
            print('você está inscrita em vôlei')
else:
    print('você não esta nos requisitos')    