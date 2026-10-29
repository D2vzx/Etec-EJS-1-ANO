SAL=int(input('Digite o valor do seu salário '))
ANOS=int(input('Digite seus anos de empresa '))
if ANOS >=5 :
    SALA=SAL*0.20
   
else:
    SALA=SAL*0.10
SALAR=SALA+SAL
print('Seu salário antes do bonûs é de {}'.format(SAL))
print('Seu bonûs é de {}'.format(SALA))
print('Seu salário com bonûs é de {}'.format(SALAR))
    