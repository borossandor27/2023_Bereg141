<?php
header('Content-Type: application/json; charset=utf-8', true);
header('Access-Control-Allow-Origin: *');
header('Access-Control-Allow-Methods: GET, POST, PUT, DELETE');
/*
fogadja az url kéréseket és megválaszolja azokat
GET http://localhost/tagdijbackend/index.php?ugyfel -> minden ugyfel
GET http://localhost/tagdijbackend/index.php?ugyfel/{id} -> adott id ugyfel
POST http://localhost/tagdijbackend/index.php?ugyfel -> létrehoz ugyfel
PUT http://localhost/tagdijbackend/index.php?ugyfel/{id} -> adott id ugyfel
DELETE http://localhost/tagdijbackend/index.php?ugyfel/{id} -> adott id ugyfel
*/
//        var_dump($_SERVER['REQUEST_METHOD']);
//        var_dump(QUERY_STRING);
$kereSzoveg = explode('/', $_SERVER['QUERY_STRING']);
if ($kereSzoveg[0] === "ugyfel") {
    require_once 'ugyfel/index.php';
} else {
    http_response_code(404);
    //-- hibaüzenet küldése JSON formátumban
    $errorJson = array("message" => 'Nincs ilyen API');
    return json_encode($errorJson);
}
