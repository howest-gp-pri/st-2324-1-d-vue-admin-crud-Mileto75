# Pri.Vue.Store Admin CRUD producten en categorieën

- Clone deze opdracht, werk dus niet verder op je vorige opdracht

In deze oefening is het de bedoeling om CRUD te voorzien voor de producten en categorieën van de shop.

Alle HTML en CSS is reeds voorzien, je dient enkel nog Vue toe te voegen en/of uit te werken.

## CRUD Categorieën

- Zorg ervoor dat enkel een ingelogde gebruiker die de `Admin` role bevat in zijn/haar claims de content op de pagina kan zien. Indien er geen Admin ingelogd is wordt een foutmelding voorzien;
  - Je kan dit zelf testen door een nieuwe gebruiker te registeren (via Swagger) en deze aangemaakte gebruiker daarna in te loggen in de shop

![](/images/image-02.png)

- bekijk hiervoor de reeds aanwezige methoden en constanten in `site.js` en gebruik deze op een logische manier in de `created` property van je Vue instantie op de Categories page.

### Opvragen categorieën

- indien de ingelogde gebruiker de role **Admin** heeft wordt een tabel getoond van alle categorieën. Per categorie toon je een rij met onderstaande gegevens;
  - afbeelding van de categorie
  - naam van de category
  - twee knoppen; **Delete** en **Bewerk**
- werk de hiervoor de aanwezige method property `showCategories` uit.

```javascript
methods: {
	showCategories: async function () {
		// Voorzie de nodige code om categorieën op te vragen van de API
		// Denk aan de logica omtrent het al of niet tonen van de errorSection, categoriesSection, ...
		// Bekijk hiervoor de aanwezige properties in de data property
	}
}
```

De HTML tabel werd hiervoor al voorzien;

- verander de waarde van `showCategoriesSection` om de HTML table te tonen. In de `data` property van de Vue instantie staat deze ingesteld op `false`
- toon door middel van een passend Vue-directive rijen per categorie
- pas table-data elementen aan met de nodige Vue-directives om alle gevraagde gegevens per rij te tonen.

Voorbeeld:
![](/images/image-01.png)

### Aanmaken nieuwe categorie
- Bij het klikken op de knop **Nieuwe categorie** zal een Bootstrap modal getoond worden;

![](/images/image-03.png)

- Gebruik een passend directive om de naam van een nieuwe categorie te koppelen aan de correcte property van het aanwezige `newCategoryModel` object in de `data` property.

- Bij het klikken op **Annuleren** voer je de `cancelCategoryAction` method property uit. In deze methode voorzie je de nodige code om het `newCategoryModel` te resetten.

- Bij het klikken op **Opslaan** voer je de `createCategory` method property uit. In deze methode voorzie je de nodige code om het `newCategoryModel` door te sturen naar de API met een **POST** request. In `site.js` is reeds een object `axiosConfig` aanwezig die je mee dient te geven met de Axios `post` methode. Ga in de cursus Vue op zoek in welke volgorde de argumenten moeten meegegeven worden aan deze `post` methode.

> Net zoals we in Swagger, Postman, HttpClient, ... de token moeten meegeven dienen we dit ook bij Axios methodes te doen die beveiligde endpoints aanspreken.
>
> In het `axiosConfig` object voorzien we een **headers** property met een object die een **Authorization** property bevat. De waarde hiervan moet `Bearer <token-hier>` zijn. Aangezien we de token in de vorige oefening hebben bewaard in de `sessionStorage` kunnen we deze dan ook hier gaan opvragen.
> ```javascript
> let axiosConfig = {
>     headers: { Authorization: `Bearer ${sessionStorage.getItem("token")}` }
> };
> ```

- om de Bootstrap modal terug te sluiten kun je volgende JS code voorzien (in de finally methode):

```javascript
const modalElement = document.getElementById("createCategoryModal");
const modal = bootstrap.Modal.getInstance(modalElement);
modal.hide();
```

> Merk op dat je dan wel het correcte id meegeeft bij de `getElementById` methode!

### Bewerken categorie
- Bij het klikken op de knop **Bewerk**  voer je de `showUpdateModal` methode property uit. Geef de category die bewerkt moet worden mee als argument met deze methode. Deze methode zal een Bootstrap modal tonen;

![](/images/image-04.png)

- om de Bootstrap modal te tonen werd de nodige code reeds voorzien in de  `showUpdateModal` methode:

```javascript
showUpdateModal: function (category) {
	this.selectedCategory = category;
	const modalElement = document.getElementById("updateCategoryModal");
	const modal = bootstrap.Modal.getInstance(modalElement);
	modal.show();
},
```

- Gebruik een passend directive in de modal om de naam van de categorie te koppelen aan de correcte property van het aanwezige `selectedCategory` object in de `data` property.

- Bij het klikken op **Annuleren** voer je de `cancelCategoryAction` method property uit. In deze methode voorzie je de nodige code om het `selectedCategory` te resetten.

- Bij het klikken op **Opslaan** voer je de `updateCategory` method property uit. Geef dan ok de `selectedCategory` mee als argument. In deze methode voorzie je de nodige code om de `categoryToUpdate` parameter door te sturen naar de API met een **PUT** request. In `site.js` is reeds een object `axiosConfig` aanwezig die je mee dient te geven met de Axios `put` methode. Ga in de cursus Vue op zoek in welke volgorde de argumenten moeten meegegeven worden aan deze `put` methode.

### Verwijderen categorie
- Bij het klikken op de knop **Delete** zal een Bootstrap modal getoond worden;

![](/images/image-05.png)

- Werk de `showDeleteModal` methode propery zelf uit, baseer je op de `showUpdateModal` methode die je reeds hebt gekregen.

- Gebruik een passend directive om de naam van de categorie te koppelen aan de correcte property van het aanwezige `selectedCategory` object in de `data` property.

- Bij het klikken op **Annuleren** hoef je niks te doen. Het modal zal sluiten door middel van het reeds aanwezige `data-bs-dismiss` element.

- Bij het klikken op **Verwijder** voer je de `deleteCategory` method property uit. Geef dan ok de `selectedCategory` mee als argument. In deze methode voorzie je de nodige code om de **id** van `categoryToDelete` uit te lezen en deze te gebruiken in de URL voor het endpoint van de API met een **DELETE** request. In `site.js` is reeds een object `axiosConfig` aanwezig die je mee dient te geven met de Axios `delete` methode. Ga in de cursus Vue op zoek in welke volgorde de argumenten moeten meegegeven worden aan deze `delete` methode.

## CRUD Producten

- De startsituatie ziet er zo uit:

![](/images/image-10.png)

- Je krijgt de nodige HTML maar toont of verbergt secties door middel van `v-if` en `v-else` directives te gebruiken.

- Zorg ervoor dat enkel een ingelogde gebruiker die de `Admin` role bevat in zijn/haar claims de content op de pagina kan zien. Indien er geen Admin ingelogd is wordt een foutmelding voorzien;
  - Je kan dit zelf testen door een nieuwe gebruiker te registeren (via Swagger) en deze aangemaakte gebruiker daarna in te loggen in de shop


- bekijk hiervoor de reeds aanwezige methoden en constanten in `site.js` en gebruik deze op een logische manier in de `created` property van je Vue instantie op de Categories page.

![](/images/image-06.png)

### Opvragen producten

- indien de ingelogde gebruiker de role **Admin** heeft wordt een tabel getoond van alle producten. Per product toon je een rij met onderstaande gegevens;
  - afbeelding van het product
  - naam van het product
  - prijs van het product
  - twee knoppen; **Delete** en **Bewerk**
- werk een zelf aan te maken methode uit. Baseer je op de categorieën pagina/uitwerking.


Voorbeeld:
![](/images/image-06.png)

### Aanmaken nieuw product
- Bij het klikken op de knop **Nieuw product** zal een Bootstrap modal getoond worden;

![](/images/image-07.png)

- Gebruik een passende directives om de gegevens te koppelen aan een zelf gemaakt object in de `data` property. Baseer je op de categorieën pagina/uitwerking.
- Vergeet niet om de `select` te vullen met categorieën, je zal dus alle categorieën moeten opvragen aan de API.

- Werk het klikken op **Annuleren** uit
- Werk het klikken op **Opslaan** uit

### Bewerken product
- Bij het klikken op de knop **Bewerk** zal een Bootstrap modal getoond worden;

![](/images/image-08.png)

- Gebruik een passende directives om de gegevens te koppelen aan een zelf gemaakt object in de `data` property. Baseer je op de categorieën pagina/uitwerking.
- Vergeet niet om de `select` te vullen met categorieën

- Werk het klikken op **Annuleren** uit
- Werk het klikken op **Opslaan** uit

### Verwijderen product
- Bij het klikken op de knop **Delete** zal een Bootstrap modal getoond worden;

![](/images/image-09.png)

- Gebruik een passende directives om de gegevens te koppelen aan een zelf gemaakt object in de `data` property. Baseer je op de categorieën pagina/uitwerking.

- Bij het klikken op **Annuleren** hoef je niks te doen. Het modal zal sluiten door middel van het reeds aanwezige `data-bs-dismiss` element.

- Werk het klikken op **Verwijder** uit

## Extra's
- Toon de foutboodschappen op basis van de statuscode van de HTTP request. Bijvoorbeeld;
	- Bij een statuscode 401 geef je als melding: "Onvoldoende rechten!"
	- Bij een statuscode 400 lees je de foutboodschap uit die zich in de errorMessage van de response bevindt