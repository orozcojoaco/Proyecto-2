-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-05-2024 a las 22:44:09
-- Versión del servidor: 10.4.27-MariaDB
-- Versión de PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `disaster`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre_completo` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contrasena` varchar(50) NOT NULL,
  `foto` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre_completo`, `correo`, `usuario`, `contrasena`, `foto`) VALUES
(1, 'Máximo Goitia', 'maximogoitia277@gmail.com', 'maxi_mfg12', '5bdc39b28edb8cfa67e1fbb5ee8ad7b8d03feb84a179507651', ''),
(2, 'pepe', 'pepe@a.com', 'pepe27', '3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3e', ''),
(10, 'a', 'pepe1276@a.com', 'as', '0cc175b9c0f1b6a831c399e269772661', ''),
(11, 'gino mazzaglia', 'mazzagliagin@gmail.com', 'kayden', '81dc9bdb52d04dc20036dbd8313ed055', ''),
(12, 'Agus Camata', 'camataagustin1@gmail.com', 'Agu', '202cb962ac59075b964b07152d234b70', ''),
(13, 'Jatniel Requena', 'jatnielrequenaet26@gmail.com', 'jatnielr', '81dc9bdb52d04dc20036dbd8313ed055', '');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `correo` (`correo`),
  ADD UNIQUE KEY `usuario` (`usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
