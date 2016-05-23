/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : jadwal_kuliah

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-05-23 23:17:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for dosen
-- ----------------------------
DROP TABLE IF EXISTS `dosen`;
CREATE TABLE `dosen` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of dosen
-- ----------------------------
INSERT INTO `dosen` VALUES ('13', 'Agus Muliantara, S.Kom.,M.Kom');
INSERT INTO `dosen` VALUES ('14', 'I Putu Gede Hendra Suputra, S.Kom., M.Kom');
INSERT INTO `dosen` VALUES ('15', 'I Gede Arta Wibawa,ST');
INSERT INTO `dosen` VALUES ('16', 'I Wayan Supriana, S.Si., M.Cs');
INSERT INTO `dosen` VALUES ('17', 'Made Agung Raharja, SSi.,M.Cs.');
INSERT INTO `dosen` VALUES ('18', 'Ida Bagus Gede Dwidasmara,S.Kom.,M.Kom');
INSERT INTO `dosen` VALUES ('20', 'I Gusti Agung Gede Arya Kadyanan');
INSERT INTO `dosen` VALUES ('21', 'Ida Bagus Made Mahendra,S.Kom.,M.Kom');
INSERT INTO `dosen` VALUES ('22', 'Luh Arida Ayu Rahning Putri,S.Kom');
INSERT INTO `dosen` VALUES ('23', 'I Komang Ari Mogi');
INSERT INTO `dosen` VALUES ('24', 'I Dewa Made Bayu Atmaja Darmawan.S.Kom.,M.Cs');
INSERT INTO `dosen` VALUES ('25', 'I G N Anom Cahyadi Putra, ST., M.Cs');
INSERT INTO `dosen` VALUES ('26', 'I Made Widiartha,S.Si.,M.Kom');
INSERT INTO `dosen` VALUES ('27', 'Drs. I Wayan Santiyasa, M.Si');
INSERT INTO `dosen` VALUES ('28', 'I Gede Santi Astawa, ST');
INSERT INTO `dosen` VALUES ('29', 'Dra. Ni Luh Gede Astuti, M.Kom');
INSERT INTO `dosen` VALUES ('30', 'Drs. I Made Karda, M.Si');
INSERT INTO `dosen` VALUES ('31', 'I Putu Ari Astawa, S.Pt, MP');
INSERT INTO `dosen` VALUES ('32', 'Luh Putu Ida Harini, S.Si');

-- ----------------------------
-- Table structure for jadwal_ag
-- ----------------------------
DROP TABLE IF EXISTS `jadwal_ag`;
CREATE TABLE `jadwal_ag` (
  `id_matkul_dosen` int(11) DEFAULT NULL,
  `id_ruangan` int(11) DEFAULT NULL,
  `id_waktu` int(11) DEFAULT NULL,
  KEY `id_matkul_dosen` (`id_matkul_dosen`),
  KEY `id_ruangan` (`id_ruangan`),
  KEY `id_waktu` (`id_waktu`),
  CONSTRAINT `jadwal_ag_ibfk_1` FOREIGN KEY (`id_matkul_dosen`) REFERENCES `matkul_dosen` (`id`),
  CONSTRAINT `jadwal_ag_ibfk_2` FOREIGN KEY (`id_ruangan`) REFERENCES `ruangan` (`id`),
  CONSTRAINT `jadwal_ag_ibfk_3` FOREIGN KEY (`id_waktu`) REFERENCES `waktu` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of jadwal_ag
-- ----------------------------

-- ----------------------------
-- Table structure for larangan
-- ----------------------------
DROP TABLE IF EXISTS `larangan`;
CREATE TABLE `larangan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_dosen` int(11) DEFAULT NULL,
  `id_waktu` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_dosen` (`id_dosen`),
  KEY `id_waktu` (`id_waktu`),
  CONSTRAINT `larangan_ibfk_1` FOREIGN KEY (`id_dosen`) REFERENCES `dosen` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `larangan_ibfk_2` FOREIGN KEY (`id_waktu`) REFERENCES `waktu` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of larangan
-- ----------------------------

-- ----------------------------
-- Table structure for matkul
-- ----------------------------
DROP TABLE IF EXISTS `matkul`;
CREATE TABLE `matkul` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) DEFAULT NULL,
  `sks` varchar(255) DEFAULT NULL,
  `semester` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of matkul
-- ----------------------------
INSERT INTO `matkul` VALUES ('7', 'Pengenalan Pola', '3', '6');
INSERT INTO `matkul` VALUES ('8', 'Data mining', '3', '6');
INSERT INTO `matkul` VALUES ('9', 'Pengantar robotika', '3', '6');
INSERT INTO `matkul` VALUES ('10', 'Algoritma genetika', '3', '6');
INSERT INTO `matkul` VALUES ('11', 'Jaringan syaraf tiruan', '3', '6');
INSERT INTO `matkul` VALUES ('12', 'Basis data terdistribusi', '3', '6');
INSERT INTO `matkul` VALUES ('13', 'Data warehouse', '3', '6');
INSERT INTO `matkul` VALUES ('14', 'Pengujian perangkat lunak', '3', '6');
INSERT INTO `matkul` VALUES ('15', 'E-comerce', '3', '6');
INSERT INTO `matkul` VALUES ('16', 'Sistem informasi manajemen', '3', '6');
INSERT INTO `matkul` VALUES ('17', 'Keamanan jaringan', '3', '6');
INSERT INTO `matkul` VALUES ('18', 'Komputasi paralel', '3', '6');
INSERT INTO `matkul` VALUES ('19', 'Socket programing', '3', '6');
INSERT INTO `matkul` VALUES ('20', 'Cloud computing', '3', '6');
INSERT INTO `matkul` VALUES ('21', 'Sistem Digital', '3', '2');
INSERT INTO `matkul` VALUES ('22', 'Organisasi dan Arsitektur Komputer', '3', '2');
INSERT INTO `matkul` VALUES ('23', 'Struktur Data', '3', '2');
INSERT INTO `matkul` VALUES ('24', 'Statistika Dasar', '3', '2');
INSERT INTO `matkul` VALUES ('25', 'Matematika Diskrit', '3', '2');
INSERT INTO `matkul` VALUES ('26', 'Komunikasi Data dan Jaringan Komp.', '3', '4');
INSERT INTO `matkul` VALUES ('27', 'Rekayasa Perangkat Lunak', '3', '4');
INSERT INTO `matkul` VALUES ('28', 'Basis Data Lanjut', '3', '4');
INSERT INTO `matkul` VALUES ('29', 'Pengantar Kecerdasan Buatan', '3', '4');
INSERT INTO `matkul` VALUES ('30', 'Riset Operasi', '3', '4');
INSERT INTO `matkul` VALUES ('31', 'Kewirausahaan', '2', '4');
INSERT INTO `matkul` VALUES ('32', 'Interaksi Manuasia dan Komputer', '3', '4');
INSERT INTO `matkul` VALUES ('33', 'Metode Penelitian', '2', '6');
INSERT INTO `matkul` VALUES ('34', 'Pemrograman Berbasis Web', '3', '6');
INSERT INTO `matkul` VALUES ('35', 'Ilmu Sosial Budaya Dasar', '2', '2');
INSERT INTO `matkul` VALUES ('36', 'Kalkulus II', '3', '2');

-- ----------------------------
-- Table structure for matkul_dosen
-- ----------------------------
DROP TABLE IF EXISTS `matkul_dosen`;
CREATE TABLE `matkul_dosen` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_matkul` int(11) DEFAULT NULL,
  `id_dosen` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_matkul` (`id_matkul`) USING BTREE,
  KEY `id_dosen` (`id_dosen`),
  CONSTRAINT `matkul_dosen_ibfk_1` FOREIGN KEY (`id_matkul`) REFERENCES `matkul` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `matkul_dosen_ibfk_2` FOREIGN KEY (`id_dosen`) REFERENCES `dosen` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of matkul_dosen
-- ----------------------------
INSERT INTO `matkul_dosen` VALUES ('18', '7', '13');
INSERT INTO `matkul_dosen` VALUES ('19', '8', '14');
INSERT INTO `matkul_dosen` VALUES ('20', '9', '15');
INSERT INTO `matkul_dosen` VALUES ('21', '10', '16');
INSERT INTO `matkul_dosen` VALUES ('22', '11', '17');
INSERT INTO `matkul_dosen` VALUES ('23', '12', '18');
INSERT INTO `matkul_dosen` VALUES ('24', '13', '22');
INSERT INTO `matkul_dosen` VALUES ('25', '14', '20');
INSERT INTO `matkul_dosen` VALUES ('26', '15', '21');
INSERT INTO `matkul_dosen` VALUES ('27', '16', '22');
INSERT INTO `matkul_dosen` VALUES ('28', '17', '23');
INSERT INTO `matkul_dosen` VALUES ('29', '18', '15');
INSERT INTO `matkul_dosen` VALUES ('30', '19', '24');
INSERT INTO `matkul_dosen` VALUES ('31', '20', '25');
INSERT INTO `matkul_dosen` VALUES ('32', '33', '28');
INSERT INTO `matkul_dosen` VALUES ('33', '34', '14');

-- ----------------------------
-- Table structure for ruangan
-- ----------------------------
DROP TABLE IF EXISTS `ruangan`;
CREATE TABLE `ruangan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of ruangan
-- ----------------------------
INSERT INTO `ruangan` VALUES ('1', 'bc 11');
INSERT INTO `ruangan` VALUES ('2', 'bc 12');
INSERT INTO `ruangan` VALUES ('3', 'bc 22');
INSERT INTO `ruangan` VALUES ('4', 'bc 21');
INSERT INTO `ruangan` VALUES ('5', 'bd 11');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', 'admin', 'admin');

-- ----------------------------
-- Table structure for waktu
-- ----------------------------
DROP TABLE IF EXISTS `waktu`;
CREATE TABLE `waktu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hari` int(11) DEFAULT NULL,
  `jam` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of waktu
-- ----------------------------
INSERT INTO `waktu` VALUES ('25', '1', '08.30 - 11.00');
INSERT INTO `waktu` VALUES ('26', '2', '08.30 - 11.00');
INSERT INTO `waktu` VALUES ('27', '3', '08.30 - 11.00');
INSERT INTO `waktu` VALUES ('28', '4', '08.30 - 11.00');
INSERT INTO `waktu` VALUES ('29', '5', '08.30 - 11.00');
INSERT INTO `waktu` VALUES ('30', '1', '12.00 - 14.30');
INSERT INTO `waktu` VALUES ('31', '2', '12.00 - 14.30');
INSERT INTO `waktu` VALUES ('32', '3', '12.00 - 14.30');
INSERT INTO `waktu` VALUES ('33', '4', '12.00 - 14.30');
INSERT INTO `waktu` VALUES ('34', '5', '12.00 - 14.30');
