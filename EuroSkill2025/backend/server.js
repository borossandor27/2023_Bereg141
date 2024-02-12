/*
*
*/
const maxBLOCKS = 5; //-- a hajódokkban lévő blokkok száma
const maxBAYS = 5; //-- egy blokkban lévő bay-ek száma
const maxSTACKS = 5; //-- egy blokkban lévő stack-ek száma
const maxTIERS = 5; //-- egy blokkban lévő tier-ek száma

const express = require('express');
const PORT = 3001;
const csv = require('csv-parser');
const fs = require('fs');

const app = express();

app.use(express.json());

app.post('/api/containers/import', (req, res) => {
    const filePath = '/path/to/assets/import.csv'; // Update with the actual path to your CSV file

    const incorrectlyPositionedContainers = [];

    fs.createReadStream(filePath)
        .pipe(csv())
        .on('data', (row) => {
            // Process each row of the CSV file
            const containerCode = row['Container Code'];
            const blockNumber = parseInt(row['Block Number']);
            const bayNumber = parseInt(row['Bay Number']);
            const stackNumber = parseInt(row['Stack Number']);
            const tierNumber = parseInt(row['Tier Number']);
            const arrivalTime = parseInt(row['Arrival Time']);

            // Perform validation and insertion logic here
            // ...

            // If the container is incorrectly positioned, add it to the list
            if (/* container is incorrectly positioned */) {
                incorrectlyPositionedContainers.push(containerCode);
            }
        })
        .on('end', () => {
            // Return the response with the number of successfully inserted containers and the list of incorrectly positioned containers
            const response = {
                success: incorrectlyPositionedContainers.length,
                incorrectPositions: incorrectlyPositionedContainers
            };

            res.status(200).json(response);
        });
});

app.post('/api/containers', (req, res) => {
    const containers = req.body;

    // Process the list of containers
    // ...

    // Return the response with the number of successfully inserted containers and the list of incorrectly positioned containers
    const response = {
        success: 35,
        incorrectPositions: ["UUKJ5448686", "UUKJ5448612"]
    };

    res.status(200).json(response);
});


app.listen(PORT, () => {
    console.log(`Server is running on port ${PORT}`);
});
