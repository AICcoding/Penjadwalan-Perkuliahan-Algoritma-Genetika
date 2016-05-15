-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 15, 2016 at 07:18 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `jadwal_kuliah`
--

-- --------------------------------------------------------

--
-- Table structure for table `dosen`
--

CREATE TABLE IF NOT EXISTS `dosen` (
`id` int(11) NOT NULL,
  `nama` varchar(255) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dosen`
--

INSERT INTO `dosen` (`id`, `nama`) VALUES
(7, 'suprix'),
(8, 'edmodo'),
(11, 'gus mul'),
(12, 'hendra');

-- --------------------------------------------------------

--
-- Table structure for table `larangan`
--

CREATE TABLE IF NOT EXISTS `larangan` (
`id` int(11) NOT NULL,
  `id_dosen` int(11) DEFAULT NULL,
  `id_waktu` int(11) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `larangan`
--

INSERT INTO `larangan` (`id`, `id_dosen`, `id_waktu`) VALUES
(21, 11, 20),
(22, 8, 21);

-- --------------------------------------------------------

--
-- Table structure for table `matkul`
--

CREATE TABLE IF NOT EXISTS `matkul` (
`id` int(11) NOT NULL,
  `nama` varchar(255) DEFAULT NULL,
  `sks` varchar(255) DEFAULT NULL,
  `semester` varchar(255) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `matkul`
--

INSERT INTO `matkul` (`id`, `nama`, `sks`, `semester`) VALUES
(3, 'PCD', '3', '5'),
(4, 'POLA', '3', '6'),
(5, 'mobile', '3', '5'),
(6, 'web', '3', '6');

-- --------------------------------------------------------

--
-- Table structure for table `matkul_dosen`
--

CREATE TABLE IF NOT EXISTS `matkul_dosen` (
`id` int(11) NOT NULL,
  `id_matkul` int(11) DEFAULT NULL,
  `id_dosen` int(11) DEFAULT NULL,
  `id_ruangan` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `matkul_dosen`
--

INSERT INTO `matkul_dosen` (`id`, `id_matkul`, `id_dosen`, `id_ruangan`) VALUES
(8, 3, 11, 2),
(10, 6, 12, 5);

-- --------------------------------------------------------

--
-- Table structure for table `ruangan`
--

CREATE TABLE IF NOT EXISTS `ruangan` (
`id` int(11) NOT NULL,
  `nama` varchar(255) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ruangan`
--

INSERT INTO `ruangan` (`id`, `nama`) VALUES
(1, 'bc 11'),
(2, 'bc 12'),
(3, 'bc 22'),
(4, 'bc 21'),
(5, 'db 11');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
`id` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `waktu`
--

CREATE TABLE IF NOT EXISTS `waktu` (
`id` int(11) NOT NULL,
  `hari` int(11) DEFAULT NULL,
  `jam` varchar(15) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `waktu`
--

INSERT INTO `waktu` (`id`, `hari`, `jam`) VALUES
(16, 1, '08.30 - 11.00'),
(17, 2, '08.30 - 11.00'),
(18, 3, '08.30 - 11.00'),
(19, 4, '08.30 - 11.00'),
(20, 5, '08.30 - 11.00'),
(21, 1, '12.00 - 14.30'),
(22, 2, '12.00 - 14.30'),
(23, 3, '12.00 - 14.30'),
(24, 4, '12.00 - 14.30');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dosen`
--
ALTER TABLE `dosen`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `larangan`
--
ALTER TABLE `larangan`
 ADD PRIMARY KEY (`id`), ADD KEY `id_dosen` (`id_dosen`), ADD KEY `id_waktu` (`id_waktu`);

--
-- Indexes for table `matkul`
--
ALTER TABLE `matkul`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `matkul_dosen`
--
ALTER TABLE `matkul_dosen`
 ADD PRIMARY KEY (`id`), ADD KEY `id_matkul` (`id_matkul`), ADD KEY `id_dosen` (`id_dosen`), ADD KEY `fk_id_ruangan` (`id_ruangan`);

--
-- Indexes for table `ruangan`
--
ALTER TABLE `ruangan`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `waktu`
--
ALTER TABLE `waktu`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `dosen`
--
ALTER TABLE `dosen`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `larangan`
--
ALTER TABLE `larangan`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT for table `matkul`
--
ALTER TABLE `matkul`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `matkul_dosen`
--
ALTER TABLE `matkul_dosen`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `ruangan`
--
ALTER TABLE `ruangan`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `waktu`
--
ALTER TABLE `waktu`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=25;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `larangan`
--
ALTER TABLE `larangan`
ADD CONSTRAINT `larangan_ibfk_1` FOREIGN KEY (`id_dosen`) REFERENCES `dosen` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `larangan_ibfk_2` FOREIGN KEY (`id_waktu`) REFERENCES `waktu` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `matkul_dosen`
--
ALTER TABLE `matkul_dosen`
ADD CONSTRAINT `matkul_dosen_ibfk_1` FOREIGN KEY (`id_matkul`) REFERENCES `matkul` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `matkul_dosen_ibfk_2` FOREIGN KEY (`id_dosen`) REFERENCES `dosen` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `matkul_dosen_ibfk_3` FOREIGN KEY (`id_ruangan`) REFERENCES `ruangan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
