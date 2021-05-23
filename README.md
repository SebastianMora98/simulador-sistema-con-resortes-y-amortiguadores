# Simulador 
## _Sistema con Resortes y Amortiguadores_

## Variables y Funciones Octave

cuando k1 se considera resorte

```
clear;
pkg load control;
s=tf('s');
m1=100;
m2=200;
k1=2;
k2=10;
b1=1;
a1=m1*s^2+k1+b1*s;
a2=b1*s;
a3=m2*s^2+k2+b1*s;
a4=b1*s;
g1=(a2)/(a3*a1-a2^2);
g2=a1/(a3*(a1-(a2^2)));

step(g1);  #impulse(g1);
step(g2);  #impulse(g2);
```

cuando k1 se considera amortiguador

```
clear;
pkg load control;
s=tf('s');
m1=100;
m2=200;
k2=10;
b1=1;
b2=1;
a1=m1*s^2+(b2*s)+b1*s;
a2=b1*s;
a3=m2*s^2+k2+b2*s;
a4=b2*s;
g1=(a4)/((a3*a1)-(a2*a4));
g2=(a1)/(a3*(a1-(a2*a4)));

step(g2)
```

![image3](https://user-images.githubusercontent.com/13090594/119244699-aa05c680-bb38-11eb-863c-d6522d7dc904.png)

## Paquetes

| Package | README |
| ------ | ------ |
| Octave.NET 3.0.0 | [https://www.nuget.org/packages/Octave.NET/][PlDb] |


## Demo

![ezgif-6-db61b48eba75](https://user-images.githubusercontent.com/13090594/119244716-dc172880-bb38-11eb-8783-bad6357fd3e6.gif)
