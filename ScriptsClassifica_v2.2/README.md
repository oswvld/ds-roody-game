# ScriptsClassifica_v2.2

Version: 2.2
Data: 17/11



Scripts per la gestione e visualizzazione della classifica.

### Contenuto package

```
- CheckPunteggio.cs
- FivePunteggi.cs
- GetPunteggi.cs
- Punteggio.cs
- ResultCheckPunteggio.cs
- ResultFivePunteggi.cs
- ResultGetPunteggi.cs
- ResultSalvaPunteggio.cs
- SalvaPunteggio.cs
- PunteggioController (OBJ prefab, da mettere in scena per far funzionare tutto!)
- FirstFive.cs
- ResultFirstFive.cs
```





# CheckPunteggio.cs

Script che si occupa di controllare se il punteggio da salvare rientra tra i primi 250 in classifica

#### To-Do
- Modificare url_five con link indicato per mail
- aggiungere OnCollisionEnter2D() o OnTriggerEnter2D()
```
void OnCollisionEnter2D(Collision2D other) {
	float nuovo_punteggio = /* variabile che indica il tempo rimasto/punteggio */;
	checkPunteggio(nuovo_punteggio);
}

void OnTriggerEnter(Collider2D other) {
	float nuovo_punteggio = /* variabile che indica il tempo rimasto/punteggio */;
	checkPunteggio (nuovo_punteggio);
}
```

- modificare funzione inClassifica()
- modificare funzione nonInClassifica()




# SalvaPunteggio.cs

Script che si occupa di controllare se il punteggio da salvare rientra tra i primi 250 in classifica

#### To-Do
- Modificare url_save con link indicato per mail
- aggiungere OnCollisionEnter2D() o OnTriggerEnter2D()
```
void OnCollisionEnter2D(Collision2D other) {
	salvaPunteggio(nome, tempo_rimasto);
}

void OnTriggerEnter(Collider2D other) {
	salvaPunteggio(nome, tempo_rimasto);
}
```
- modificare la funzione success()



# FivePunteggi.cs

Script che si occupa di prendere i punteggi adiacenti a quelli del giocatore corrente, e del suo punteggio

#### To-Do
- Modificare url_check con link indicato per mail
- Modifica PunteggiTrovati()



# FirstFive.cs

Script che si occupa di prendere i primi 5 in classifica

#### To-Do
- Modificare url_check con link indicato per mail
- Modifica PunteggiTrovati()
