-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-02-2017 a las 19:31:40
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `interpolaridad`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `codigospostales`
--

CREATE TABLE `codigospostales` (
  `codigoPostal` varchar(500) NOT NULL,
  `poblacion` varchar(500) NOT NULL,
  `provincia` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='tabla sobre codigos postales, sus poblaciones y provincias';

--
-- Volcado de datos para la tabla `codigospostales`
--

INSERT INTO `codigospostales` (`codigoPostal`, `poblacion`, `provincia`) VALUES
('03202', 'Elche', 'Alicante'),
('03803', 'Alcoy', 'Alicante'),
('18014', 'Granada', 'Granada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `piezas`
--

CREATE TABLE `piezas` (
  `referencia` varchar(500) NOT NULL,
  `proveedor` int(11) NOT NULL,
  `precio` float NOT NULL,
  `disponibilidad` tinyint(1) NOT NULL,
  `fechaDisp` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `piezas`
--

INSERT INTO `piezas` (`referencia`, `proveedor`, `precio`, `disponibilidad`, `fechaDisp`) VALUES
('alfil', 22, 1.25, 1, '2017-02-05'),
('torre', 22, 1.5, 1, '2017-02-15'),
('rey', 2, 2, 0, '2017-02-24'),
('reina', 2, 2, 1, '2017-02-06');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `presupuestos`
--

CREATE TABLE `presupuestos` (
  `id` int(11) NOT NULL,
  `fechaPresupuesto` date NOT NULL,
  `idcliente` int(11) NOT NULL,
  `referenciaProducto` varchar(500) NOT NULL,
  `cantidadProducto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `presupuestos`
--

INSERT INTO `presupuestos` (`id`, `fechaPresupuesto`, `idcliente`, `referenciaProducto`, `cantidadProducto`) VALUES
(1, '2017-02-16', 2, 'Referencia', 2),
(2, '2017-02-16', 3, 'intento 2', 3),
(3, '2016-02-16', 22, 'Prueba', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `skey`
--

CREATE TABLE `skey` (
  `SoapKey` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Almacena las SoapKey' ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `skey`
--

INSERT INTO `skey` (`SoapKey`) VALUES
('interpolaridad'),
('12345');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `presupuestos`
--
ALTER TABLE `presupuestos`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `presupuestos`
--
ALTER TABLE `presupuestos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
