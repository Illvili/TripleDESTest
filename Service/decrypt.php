<?php
// decoded with base64
// and decrypt a message

// data to decrypt
$message = base64_decode($_POST['data']);
// include key and iv config
include 'tdes.config.php';

echo mcrypt_decrypt(MCRYPT_3DES, $key, $message, MCRYPT_MODE_CBC, $iv);
?>