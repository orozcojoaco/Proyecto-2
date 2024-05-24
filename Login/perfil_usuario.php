<?php 

        require_once "includes/conexion.php";

        if (isset($_GET['id'])) {
            $id = $_GET['id'];
            $consulta = "SELECT * FROM usuarios WHERE id = '$id'";
            $run = mysqli_query($conexion, $consulta);
            $usuarios = mysqli_fetch_all($run, MYSQLI_ASSOC);
        }

        
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <?php require_once "includes/header.php"; ?>
    <?php require_once "includes/style-listado-usuarios.php"; ?>

    <title>Perfil usuario</title>
</head>
<body>
    
    <header>
        <div class="logo">
            <img src="https://static.thenounproject.com/png/194335-200.png" style="height: 80px; width: 80px; padding: 5px; margin: 5px;">
            <strong style="font-size: 25px;">CYBERVOLUNTARIOS</strong>
        </div>
        <nav class="asuntos">
            <a href="contact.php">Contacto</a>
            <a href="sobre_nosotros.php">Sobre Nosotros</a>
            <button class="btnlogin"><a href="login_register/index.php">Logout</a></button>
        </nav>
    </header>
    <style>
        .caja_perfil{
            display: flex;
            justify-content: center;
            align-items: center;
        }

        form{
            width: 100%;
            display: flex;
            flex-direction: column;
            justify-content: center; 
            align-items: center;
            border: 2px solid black;
            border-radius: 10px 25px 10px 25px;
            width: 250px;
            height: 400px;
        }

        .basura{
            display: none;
        }
    </style>
    <main>

        <div class="caja_perfil">

        <?php foreach ($usuarios as $usuarios) {
                echo "<form method='post' action='perfil_editar_abm.php?id=" . $usuarios['id'] ."'>
                <label class='basura'>ID</label><br>
                <input class='basura' name='id' readonly type='text' required value='" . $usuarios['id'] . "'><br>
                <label>Nombre completo</label><br>
                <input name='nom' type='text' required value='" . $usuarios['nombre_completo'] . "'><br>
                <label>Usuario</label><br>
                <input name='usu' type='text' required value='" . $usuarios['usuario'] . "'><br>
                <label>Correo</label><br>
                <input name='cor' type='email' required value='" . $usuarios['correo'] . "'><br>
                <input type='submit'>
                </form>";
            }
        ?>

        </div>

    </main>

    <footer class="py-5">
        <?php require_once "includes/footer.php"; ?>
    </footer>

</body>
</html>