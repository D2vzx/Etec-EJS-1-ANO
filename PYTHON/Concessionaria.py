V=int(input('Digite o valor do carro de 2025 em promoção '))
D=(input('Digite o dia da semana que você irá adquirir o carro (minúsculo ) '))
if D=='segunda':
    VD=V*0.05
    if D=='terça':
        VD=V*0.06
        if D=='quarta':
            VD=V*0.07
            if D=='quinta':
                VD=V*0.08
                if D=='sexta':
                    VD=V*0.09
                    if D=='sabado'and 'domingo':
                        VD=V*0.10
else:
    print('você não colocou os valores certos')                        
VDD=VD-V
print('o valor do carro sem desconto é {}'.format(V))
print('O dia da semana é {}'.format(D))
print('o valor do carro com desconto é {}'.format(VDD))