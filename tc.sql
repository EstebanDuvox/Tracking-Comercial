-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 01, 2024 at 07:51 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tc`
--

-- --------------------------------------------------------

--
-- Table structure for table `estados`
--

CREATE TABLE `estados` (
  `id_estado` int(10) UNSIGNED NOT NULL,
  `prospecto` varchar(30) NOT NULL,
  `estado` enum('A estimar','Estimado','Enviado al cliente','Aprobado','Rechazado','Observado') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `perfiles`
--

CREATE TABLE `perfiles` (
  `id_perfil` int(10) UNSIGNED NOT NULL,
  `nom_E` varchar(25) NOT NULL,
  `nom_C` varchar(20) NOT NULL,
  `ap_C` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `prospectos`
--

CREATE TABLE `prospectos` (
  `prospecto` varchar(30) NOT NULL,
  `id_perfil` int(10) UNSIGNED ,
  `descr_nec_p` varchar(100) NOT NULL,
  `esp_tec_sol_c` varchar(100) NOT NULL,
  `fecha_lim` date NOT NULL,
  `pres_lim` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `Nom_U` varchar(20) NOT NULL,
  `Con_U` varchar(25) NOT NULL,
  `Tipo_U` enum('Comercial','Empleado','Gerente','Administrador') NOT NULL DEFAULT 'Comercial',
  `id_perfil` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`Nom_U`, `Con_U`, `Tipo_U`, `id_perfil`) VALUES
('Admin', '123', 'Administrador', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `estados`
--
ALTER TABLE `estados`
  ADD PRIMARY KEY (`id_estado`),
  ADD KEY `FK_estadoprospecto` (`prospecto`);

--
-- Indexes for table `perfiles`
--
ALTER TABLE `perfiles`
  ADD PRIMARY KEY (`id_perfil`);

--
-- Indexes for table `prospectos`
--
ALTER TABLE `prospectos`
  ADD PRIMARY KEY (`prospecto`),
  ADD KEY `FK_clienteprospecto` (`id_perfil`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Nom_U`),
  ADD KEY `usuarios_perfiles_FK` (`id_perfil`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `estados`
--
ALTER TABLE `estados`
  MODIFY `id_estado` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `id_perfil` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `estados`
--
ALTER TABLE `estados`
  ADD CONSTRAINT `FK_estadoprospecto` FOREIGN KEY (`prospecto`) REFERENCES `prospectos` (`prospecto`);

--
-- Constraints for table `prospectos`
--
ALTER TABLE `prospectos`
  ADD CONSTRAINT `FK_clienteprospecto` FOREIGN KEY (`id_perfil`) REFERENCES `perfiles` (`id_perfil`);

--
-- Constraints for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_perfiles_FK` FOREIGN KEY (`id_perfil`) REFERENCES `perfiles` (`id_perfil`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
