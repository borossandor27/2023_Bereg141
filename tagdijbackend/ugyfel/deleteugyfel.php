<?php

$sql = '';
if (count($kereSzoveg) > 1) {
    if (is_int(intval($kereSzoveg[1]))) {
        $sql = 'DELETE FROM ugyfel WHERE azon=' . $kereSzoveg[1];
    } 
}else {
    http_response_code(404);
    echo 'Nem létező ügyfél';
}
require_once './databaseconnect.php';

if ($result = $connection->query($sql)) {
    http_response_code(201);
    echo 'Sikeres törlés';
} else {
    http_response_code(404);
    echo 'Sikertelen törlés';
}