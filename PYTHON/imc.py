peso=float(input('Digite o seu peso '))
altura=float(input('Digite sua altura '))
imc=peso/(altura**2)
if(imc<18,5):
  print=('abaixo do peso')
else:
    if(imc<25):
      print=('Peso normal')
    else:
        if(imc<30):
            print=('Acima do peso')
        else:
           
            print=('Obeso(a)')
print('imc= {:,.2f} '.format(imc))

