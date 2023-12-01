let vue = new Vue({
    el: "#app",
    name: "categoriesAdminSection",
    data: {
        showCategoriesSection: false,
        showErrorSection: false,
        categories: null,
        errorMessage: "",
        isLoading: false,
        categoryError: false,
        baseUrl: "https://localhost:7086/api",
        newCategoryModel: {
            name: ""
        },
        selectedCategory: {
            id: "",
            name: "",
            imageUrl: "",
        }
    },
    created: async function () {
        // pas dit aan zodat enkel admins de tabel met categorieën kunnen zien
        // gebruikers die geen admin zijn zien onderstaande melding:
        this.errorMessage = "Enkel admins kunnen categorieën aanpassen. Je hebt onvoldoende rechten.";
        this.showErrorSection = false;
        //call showCategories
        this.showCategories();
    },
    methods: {
        showCategories: async function () {
            this.isLoading = true;
            const url = `${this.baseUrl}/categories`;
            this.categories =
                await axios.get(url)
                    .then(response => response.data)
                    .catch(error => {
                        this.error = true;
                        this.errorMessage = error.message;
                    })
                    .finally(() => {
                        this.isLoading = false;
                    });
            if (this.categories !== undefined) {
                this.showCategoriesSection = true;
            }
            // Voorzie de nodige code om categorieën op te vragen van de API
            // Denk aan de logica omtrent het al of niet tonen van de errorSection, categoriesSection, ...
            // Bekijk hiervoor de aanwezige properties in de data property
        },
        createCategory: async function () {
            if (this.newCategoryModel.name.trim() === "") {
                this.categoryError = true;
                this.errorMessage = "please provide a category";
                return;
            }
            this.isLoading = true;
            //call the api
            const url = `${this.baseUrl}/categories`;
            const token = sessionStorage.getItem('token');
            const headers = {
                    headers: {
                        Authorization: `Bearer ${token}`,
                    }
            };
            await axios.post(url, this.newCategoryModel,headers)
                .then(response => response.data)
                .catch(error => {
                    this.error = true;
                    this.errorMessage = error.message;
                })
                .finally(() => {
                    this.isLoading = false;
                });
            //load the categories
            this.showCategories();
            //close the modal
            $('#createCategoryModal').modal('hide');
            this.newCategoryModel.name = "";
            // Voorzie de nodige code om categorieën aan te maken via de API
            // Denk aan de logica omtrent het al of niet tonen van de errorSection, categoriesSection, ...
            // Bekijk hiervoor de aanwezige properties in de data property
        },
        updateCategory: async function (categoryToUpdate) {
            // Voorzie de nodige code om bestaande categorieën aan te passen via de API
            // Denk aan de logica omtrent het al of niet tonen van de errorSection, categoriesSection, ...
            // Bekijk hiervoor de aanwezige properties in de data property
        },
        deleteCategory: async function (categoryToDelete) {
            // Voorzie de nodige code om bestaande categorieën aan te verwijderen via de API
            // Denk aan de logica omtrent het al of niet tonen van de errorSection, categoriesSection, ...
            // Bekijk hiervoor de aanwezige properties in de data property
        },
        showUpdateModal: function (category) {
            this.selectedCategory = category;
            const modalElement = document.getElementById("updateCategoryModal");
            const modal = bootstrap.Modal.getInstance(modalElement);
            modal.show();
        },
        showCreateModal: function () {
            this.categoryError = false;
            $('#createCategoryModal').modal('show');
        },
        hideCreateModal: function () {
            $('#createCategoryModal').modal('hide');
        },
        showDeleteModal: function (category) {
            // Werk deze methode zelf uit
        },
        cancelCategoryAction: function () {
            // reset newCategoryModel
            // reset selectedCategory
        }
    }
});