<?php
//echo 'POST';
//$azon=$_POST["azon"];
$nev=$_POST["nev"];	
$szulev =$_POST["szulev"];
$irszam=$_POST["irszam"];	
$orsz=$_POST["orsz"];
//$azon=2002;
//$nev="Géza";	
//$szulev =2005;
//$irszam=4030;	
//$orsz="H";
require_once './databaseconnect.php';
$sql = "INSERT INTO ugyfel (azon, nev, szulev, irszam, orsz) VALUES (NULL, ?, ?, ?, ?)";
$stmt = $connection->prepare($sql);
$stmt->bind_param("siis",  $nev, $szulev, $irszam, $orsz);  
if ($stmt->execute()) {
    http_response_code(201);
    echo 'Sikeresen hozzáadva';
} else {
    http_response_code(404);
    echo 'Nem sikerült hozzáadni';
}