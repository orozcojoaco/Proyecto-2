<?php
$conexion = mysqli_connect("localhost", "root", "", "disaster");

if($conexion){
    echo "conexion exitosa"."<br>";
}else{
    echo "conexion fallida"."<br>";
}
?>