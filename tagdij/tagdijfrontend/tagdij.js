document.addEventListener('DOMContentLoaded', function () {
    const insertButton = document.getElementById('create');
    const readButton = document.getElementById('read');
    const updateButton = document.getElementById('update');
    const deleteButton = document.getElementById('delete');
    const dolgozoForm = document.getElementById('dolgozoForm');
    const dolgozokDiv = document.getElementById('ugyfellista');
    insertButton.addEventListener('click', async function () {
        let baseUrl = "http://localhost/tagdijbackend/index.php?ugyfel";

        const formData = new FormData(document.getElementById('dolgozoForm'));
        let options = {
            method: 'POST',
            mode: "no-cors",
            body: formData
        };
        let response = await fetch(baseUrl, options);
        if (response.ok) {
            console.log("Sikeres adatfelvitel");
        } else {
            console.error('Hiba a szerver válaszában');
        }
    });
    readButton.addEventListener('click', async function () {
        dolgozoForm.classList.add('d-none');
        dolgozokDiv.classList.remove('d-none');
        let baseUrl = "http://localhost/tagdijbackend/index.php?ugyfel";
        let options = {
            method: 'GET',
            mode: "cors"
        };
        let response = await fetch(baseUrl, options);
        if (response.ok) {
            let data = await response.json();
            dolgozokListazasa(data);
        } else {
            console.error('Hiba a szerver válaszában');
        };
    });

    function dolgozokListazasa(dolgozok) {
        let dolgozokDiv = document.getElementById('ugyfellista');
        let tablazat = dolgozoFejlec();
        for (let dolgozo of dolgozok) {
            tablazat += dolgozoSor(dolgozo);
        }
        dolgozokDiv.innerHTML = tablazat + '</tbody></table>';

    }
    function dolgozoSor(dolgozo) {
        let sor = `<tr>
            <td>${dolgozo.azon}</td>
            <td>${dolgozo.nev}</td>
            <td>${dolgozo.szulev}</td>
            <td>${dolgozo.irszam}</td>
            <td>${dolgozo.orsz}</td>
            <td><button class="btn btn-outline-dark" onclick="adatBetoltes(${dolgozo.azon})"><i class="fa-regular fa-hand-point-left"></i></button></td>
        </tr>`;
        return sor;
    }
    function dolgozoFejlec() {
        let fejlec = `<table class="table table-striped">
        <thead>
            <tr>
                <th>Azonosító</th>
                <th>Név</th>
                <th>Születési év</th>
                <th>Irányítószám</th>
                <th>Ország</th>
                <th>Művelet</th>
            </tr>
        </thead>
        <tbody>`;
        return fejlec;
    }
});
