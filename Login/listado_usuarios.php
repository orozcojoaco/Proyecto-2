<?php
session_start(); // Iniciar la sesión al principio del archivo

// Verificar si hay un nombre de usuario en la sesión
if (isset($_SESSION['usuario'])) {
    $usuario = $_SESSION['usuario'];
} else {
    $usuario = "Invitado "; // o cualquier valor predeterminado si no hay un usuario registrado
}
?>

<!DOCTYPE html>

<head>
    <?php require_once "includes/header.php"; ?>
    <?php require_once "includes/style-listado-usuarios.php"; ?>
</head>

<body>
    <header>
        <div class="logo">
            <img src="https://static.thenounproject.com/png/194335-200.png" style="height: 80px; width: 80px; padding: 5px; margin: 5px;">
            <strong style="font-size: 25px;">CYBERVOLUNTARIOS</strong>
        </div>
        <div style="display: flex;">
            <nav class="asuntos">
                <a href="home_log.php">Inicio</a>
                <a href="contact_log.php">Contacto</a>
                <a href="sobre_nosotros_log.php">Sobre Nosotros</a>
            </nav>
            <div id="nombreUsuarioContainer">
                <span id="nombreUsuario" style="font-size: 20px;"><?php echo $usuario; ?></span>
                <div id="opcionesUsuario">
                    <a href="">Cerrar sesión</a>
                </div>
            </div>
        </div>
    </header>

    <main>

        <section class="py-5 text-center inicio">
            <div>
                <div class="col-lg-6 col-md-8 mx-auto informa">
                    <img style="height: 180px; width: 180px; margin: 10px" src="https://cdn-icons-png.flaticon.com/512/86/86110.png">
                    <h1 class="fw-light">Listado de usuarios</h1>
                    <p style="color: #000; font-size: 20px">Lorem, ipsum dolor sit amet consectetur adipisicing elit. Impedit debitis sunt iure amet reprehenderit, laboriosam quisquam, alias adipisci aliquid repellendus dolorum.</p>
                </div>
            </div>
        </section>

        <center>
            <?php require_once "includes/conexion.php";

            // consulta general
            $cadena = "SELECT nombre_completo , correo , usuario, id FROM usuarios WHERE 1";
            $consulta = MySqli_query($conexion, $cadena);
            $usuarios = mysqli_fetch_all($consulta, MYSQLI_ASSOC);

            ?>

            <table border="2" cellspacing="2" cellpadding="3">

                <tr>
                    <td style="border: 2px solid black;">Nombre</td>
                    <td style="border: 2px solid black;">Correo</td>
                    <td style="border: 2px solid black;">Usuario</td>
                    <td colspan="2" style="border: 2px solid black;"></td>
                </tr>

                <?php foreach ($usuarios as $usuarios) { ?>

                    <tr>
                        <td style="border: 2px solid black;"><?php echo $usuarios['nombre_completo'] ?></td>
                        <td style="border: 2px solid black;"><?php echo $usuarios['correo'] ?></td>
                        <td style="border: 2px solid black;"><?php echo $usuarios['usuario'] ?></td>
                        <td style="border: 2px solid black;"><a href="perfil_usuario.php?id=<?php echo $usuarios['id'] ?>">EDITAR</a></td>
                        <td style="border: 2px solid black;"><a href="bajas_usuarios.php?id=<?php echo $usuarios['id'] ?>">ELIMINAR</a></td>
                    </tr>

                <?php } ?>
            </table>

            <br>
            <button class="btnlogin"><a href="home_log.php">Volver</a></button>
        </center>

    </main>


    <footer class="py-5">
        <?php require_once "includes/footer.php"; ?>
    </footer>

</body>

</html>