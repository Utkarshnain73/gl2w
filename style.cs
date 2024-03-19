body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: #f8f8f8;
}

.container {
    max-width: 800px;
    margin: 0 auto;
    padding: 20px;
}

.sort-section {
    margin-bottom: 20px;
}

.sort-section button, #categorySelect {
    margin-right: 10px;
    padding: 8px 12px;
    border: none;
    border-radius: 4px;
    background-color: #007bff;
    color: #fff;
    cursor: pointer;
}

.filter-section label {
    margin-right: 10px;
}

.products-container {
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(250px, 1fr));
    gap: 20px;
}

.product-card {
    border: 1px solid #ddd;
    border-radius: 4px;
    padding: 10px;
    background-color: #fff;
}

.product-card h3 {
    margin-top: 0;
}

.product-card p {
    margin: 5px 0;
}
