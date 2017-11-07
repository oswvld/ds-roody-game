# ScriptsClassifica_v2.1

Version: 2.1
Data: 06/10



Script per la gestione e visualizzazione della classifica.  

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
```


### TO-DO list

1) Modificare **url_five** in FivePunteggi.cs, con link indicato per mail
2) Modificare **url_save** in SalvaPunteggio.cs, con link indicato per mail
3) Modificare **url_check** in CheckPunteggio.cs, con link indicato per mail






# CheckPunteggio.cs

Script che si occupa di controllare se il punteggio da salvare rientra tra i primi 250 in classifica

#### To-Do
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