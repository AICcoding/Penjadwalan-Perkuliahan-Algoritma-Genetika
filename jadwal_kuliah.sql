-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2016 at 04:53 AM
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
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dosen`
--

INSERT INTO `dosen` (`id`, `nama`) VALUES
(13, 'Agus Muliantara, S.Kom.,M.Kom'),
(14, 'I Putu Gede Hendra Suputra, S.Kom., M.Kom'),
(15, 'I Gede Arta Wibawa,ST'),
(16, 'I Wayan Supriana, S.Si., M.Cs'),
(17, 'Made Agung Raharja, SSi.,M.Cs.'),
(18, 'Ida Bagus Gede Dwidasmara,S.Kom.,M.Kom'),
(20, 'I Gusti Agung Gede Arya Kadyanan'),
(21, 'Ida Bagus Made Mahendra,S.Kom.,M.Kom'),
(22, 'Luh Arida Ayu Rahning Putri,S.Kom'),
(23, 'I Komang Ari Mogi'),
(24, 'I Dewa Made Bayu Atmaja Darmawan.S.Kom.,M.Cs'),
(25, 'I G N Anom Cahyadi Putra, ST., M.Cs'),
(26, 'I Made Widiartha,S.Si.,M.Kom'),
(27, 'Drs. I Wayan Santiyasa, M.Si'),
(28, 'I Gede Santi Astawa, ST'),
(29, 'Dra. Ni Luh Gede Astuti, M.Kom'),
(30, 'Drs. I Made Karda, M.Si'),
(31, 'I Putu Ari Astawa, S.Pt, MP'),
(32, 'Luh Putu Ida Harini, S.Si');

-- --------------------------------------------------------

--
-- Table structure for table `jadwal_ag`
--

CREATE TABLE IF NOT EXISTS `jadwal_ag` (
  `id_matkul_dosen` int(11) DEFAULT NULL,
  `id_ruangan` int(11) DEFAULT NULL,
  `id_waktu` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jadwal_ag`
--

INSERT INTO `jadwal_ag` (`id_matkul_dosen`, `id_ruangan`, `id_waktu`) VALUES
(18, 4, 29),
(19, 1, 31),
(20, 1, 26),
(21, 1, 27),
(22, 1, 34),
(23, 5, 31),
(24, 3, 27),
(25, 1, 28),
(26, 3, 25),
(27, 2, 26),
(28, 5, 27),
(29, 2, 27),
(30, 3, 27),
(31, 1, 30),
(32, 3, 34),
(33, 4, 30);

-- --------------------------------------------------------

--
-- Table structure for table `larangan`
--

CREATE TABLE IF NOT EXISTS `larangan` (
`id` int(11) NOT NULL,
  `id_dosen` int(11) DEFAULT NULL,
  `id_waktu` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `matkul`
--

CREATE TABLE IF NOT EXISTS `matkul` (
`id` int(11) NOT NULL,
  `nama` varchar(255) DEFAULT NULL,
  `sks` varchar(255) DEFAULT NULL,
  `semester` varchar(255) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `matkul`
--

INSERT INTO `matkul` (`id`, `nama`, `sks`, `semester`) VALUES
(7, 'Pengenalan Pola', '3', '6'),
(8, 'Data mining', '3', '6'),
(9, 'Pengantar robotika', '3', '6'),
(10, 'Algoritma genetika', '3', '6'),
(11, 'Jaringan syaraf tiruan', '3', '6'),
(12, 'Basis data terdistribusi', '3', '6'),
(13, 'Data warehouse', '3', '6'),
(14, 'Pengujian perangkat lunak', '3', '6'),
(15, 'E-comerce', '3', '6'),
(16, 'Sistem informasi manajemen', '3', '6'),
(17, 'Keamanan jaringan', '3', '6'),
(18, 'Komputasi paralel', '3', '6'),
(19, 'Socket programing', '3', '6'),
(20, 'Cloud computing', '3', '6'),
(21, 'Sistem Digital', '3', '2'),
(22, 'Organisasi dan Arsitektur Komputer', '3', '2'),
(23, 'Struktur Data', '3', '2'),
(24, 'Statistika Dasar', '3', '2'),
(25, 'Matematika Diskrit', '3', '2'),
(26, 'Komunikasi Data dan Jaringan Komp.', '3', '4'),
(27, 'Rekayasa Perangkat Lunak', '3', '4'),
(28, 'Basis Data Lanjut', '3', '4'),
(29, 'Pengantar Kecerdasan Buatan', '3', '4'),
(30, 'Riset Operasi', '3', '4'),
(31, 'Kewirausahaan', '2', '4'),
(32, 'Interaksi Manuasia dan Komputer', '3', '4'),
(33, 'Metode Penelitian', '2', '6'),
(34, 'Pemrograman Berbasis Web', '3', '6'),
(35, 'Ilmu Sosial Budaya Dasar', '2', '2'),
(36, 'Kalkulus II', '3', '2');

-- --------------------------------------------------------

--
-- Table structure for table `matkul_dosen`
--

CREATE TABLE IF NOT EXISTS `matkul_dosen` (
`id` int(11) NOT NULL,
  `id_matkul` int(11) DEFAULT NULL,
  `id_dosen` int(11) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `matkul_dosen`
--

INSERT INTO `matkul_dosen` (`id`, `id_matkul`, `id_dosen`) VALUES
(18, 7, 13),
(19, 8, 14),
(20, 9, 15),
(21, 10, 16),
(22, 11, 17),
(23, 12, 18),
(24, 13, 22),
(25, 14, 20),
(26, 15, 21),
(27, 16, 22),
(28, 17, 23),
(29, 18, 15),
(30, 19, 24),
(31, 20, 25),
(32, 33, 28),
(33, 34, 14);

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
(5, 'bd 11');

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
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `waktu`
--

INSERT INTO `waktu` (`id`, `hari`, `jam`) VALUES
(25, 1, '08.30 - 11.00'),
(26, 2, '08.30 - 11.00'),
(27, 3, '08.30 - 11.00'),
(28, 4, '08.30 - 11.00'),
(29, 5, '08.30 - 11.00'),
(30, 1, '12.00 - 14.30'),
(31, 2, '12.00 - 14.30'),
(32, 3, '12.00 - 14.30'),
(33, 4, '12.00 - 14.30'),
(34, 5, '12.00 - 14.30');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dosen`
--
ALTER TABLE `dosen`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `jadwal_ag`
--
ALTER TABLE `jadwal_ag`
 ADD KEY `id_matkul_dosen` (`id_matkul_dosen`), ADD KEY `id_ruangan` (`id_ruangan`), ADD KEY `id_waktu` (`id_waktu`);

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
 ADD PRIMARY KEY (`id`), ADD UNIQUE KEY `id_matkul` (`id_matkul`) USING BTREE, ADD KEY `id_dosen` (`id_dosen`);

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
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `larangan`
--
ALTER TABLE `larangan`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `matkul`
--
ALTER TABLE `matkul`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=37;
--
-- AUTO_INCREMENT for table `matkul_dosen`
--
ALTER TABLE `matkul_dosen`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=34;
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
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=35;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `jadwal_ag`
--
ALTER TABLE `jadwal_ag`
ADD CONSTRAINT `jadwal_ag_ibfk_1` FOREIGN KEY (`id_matkul_dosen`) REFERENCES `matkul_dosen` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `jadwal_ag_ibfk_2` FOREIGN KEY (`id_ruangan`) REFERENCES `ruangan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `jadwal_ag_ibfk_3` FOREIGN KEY (`id_waktu`) REFERENCES `waktu` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

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
ADD CONSTRAINT `matkul_dosen_ibfk_2` FOREIGN KEY (`id_dosen`) REFERENCES `dosen` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
