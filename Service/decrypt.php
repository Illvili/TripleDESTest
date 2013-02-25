<?php
// decoded with base64
// and decrypt a message

// data to decrypt
$message = base64_decode($_POST['data']);
// key use to encrypt
$key = "TestKey1234567890!!!!!!!";
// initialization vector 8 bytes
$iv = "iv123!!!";


echo mcrypt_decrypt(MCRYPT_3DES, $key, $message, MCRYPT_MODE_ECB, $iv);
?>