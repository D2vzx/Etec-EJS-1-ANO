ano=int(input('Digite o ano do carro '))
valor=int(input('Digite o valor do carro '))
if (ano<=1990): 
    tx=valor*0.01
else:
    tx=valor*0.015
print('a taxa é de {}'.format(tx))
    
    