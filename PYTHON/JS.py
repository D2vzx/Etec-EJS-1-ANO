id=int(input('Digite sua idade '))
cs=(input('Você está no 3° ano de informática? (sim ou não) '))
if id>=17 and cs=='sim':
    print('você foi para a segunda fase')
    ling=(input('Você é fluente em inglês? (sim ou não) '))
    ling2=(input('Você é fluente em espanhol (sim ou não) '))                                                             
    if ling=='sim' and ling2=='não' or ling=='não' and ling2=='sim' or ling=='sim' or ling2=='sim':
        print('Você foi aprovado!')
    else:
        print('Você foi reprovado')
else:
    print('você não passou para a segunda fase')