<?php
// encrypt a message
// and encoded with base64

// data to encrypt
$message = "Hello 3DES! 中文测试";
// include key and iv config
include 'tdes.config.php';

$encrypted_message = mcrypt_encrypt(MCRYPT_3DES, $key, $message, MCRYPT_MODE_CBC, $iv);
echo base64_encode($encrypted_message);
?>