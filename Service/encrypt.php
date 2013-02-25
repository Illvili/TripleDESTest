<?php
// encrypt a message
// and encoded with base64

// data to encrypt
$message = "Hello 3DES! 中文测试";
// key use to encrypt
$key = "TestKey1234567890!!!";
// initialization vector 8 bytes
$iv = "iv123!!!";


$encrypted_message = mcrypt_encrypt(MCRYPT_3DES, $key, $message, MCRYPT_MODE_ECB, $iv);
echo base64_encode($encrypted_message);
?>