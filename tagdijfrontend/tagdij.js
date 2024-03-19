document.addEventListener('DOMContentLoaded', function() {
    const insertButton = document.getElementById('create');
    const readButton = document.getElementById('read');
    const updateButton = document.getElementById('update');
    const deleteButton = document.getElementById('delete');
    insertButton.addEventListener('click', async function(){
        let baseUrl="http://localhost/tagdijbackend/index.php?ugyfel";   
        let dataJson = {
            "nev": document.getElementById('nev').value,
            "irsz": document.getElementById('irsz').value,
            "orszag": document.getElementById('orszag').value,
            "szulev": document.getElementById('szulev').value
        };
        let options = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(dataJson)
        };
       let response = await fetch(baseUrl, options);
         let data = await response.json();
            console.log(data);
    });
           
});
