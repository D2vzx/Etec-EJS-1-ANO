s=float(input('digite o valor do seu salario'))
if(s<=1800):
    ns=s*1.20
else:
    if(s<+3200):
        ns=s*1.15
    else:
        if(s>+5000):
            ns=s*1.10
        else:
            ns=s*1.05
print('O seu novo salario é de {}'.format(ns))
    
