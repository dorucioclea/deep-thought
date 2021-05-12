# Soru 13: En uzun Collatz dizisi
Aşağıdaki tekrarlama dizisi pozitif tam sayılar için tanımlanmıştır:

```
n → n/2 (n çiftir)
n → 3n + 1 (n tektir)
```

Yukarıdaki kuralı uygulayarak ve 13’ten başlayarak aşağıdaki diziyi üretiriz:
```
13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
```
13’ten başlayıp 1’de sonlanan bu dizinin 10 adet terim içerdiği görülebilir. Henüz kanıtlanmış olmasa da(Collatz Problemi), bütün başlangıç sayılarının 1’de sonuçlanacağı sanılmaktadır.

Bir milyonun altındaki hangi başlangıç sayısı, en uzun zinciri üretir?

NOT: Zincir bir kere başladıktan sonra terimlerin 1 milyonun üzerine çıkabilmesi mümkündür.

---
# Problem 13: Large sum

The following iterative sequence is defined for the set of positive integers:

```
n → n/2 (n is even)
n → 3n + 1 (n is odd)
```


Using the rule above and starting with 13, we generate the following sequence:
```
13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
```
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.

