use pruebauni;

Create Table Edificio (
idEdificio int NOT NULL,
PRIMARY KEY (idEdificio),
nombreEdificio varchar(20)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Aulas (
idAula int NOT NULL,
PRIMARY KEY (idAula),
nombreAula varchar(20),
idEdificio int,
FOREIGN KEY (idEdificio) REFERENCES Edificio(idEdificio)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Laboratorios (
idLab int NOT NULL,
PRIMARY KEY (idLab),
nombre Varchar(20),
idEdificio int,
idAula int,
FOREIGN KEY (idEdificio) REFERENCES Edificio(idEdificio),
FOREIGN KEY (idAula) REFERENCES Aulas(idAula)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Pensum (
idPensum int NOT NULL,
PRIMARY KEY (idPensum),
año int 
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Jornada (
idJornada int NOT NULL,
PRIMARY KEY (idJornada),
jornada varchar(20)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Horarios(
idHorario int NOT NULL,
PRIMARY KEY (idHorario),
idJornada int,
dia varchar(10),
hora time,
FOREIGN KEY (idJornada) REFERENCES Jornada(idJornada)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Cursos (
idCurso int NOT NULL,
PRIMARY KEY (idCurso),
nombre Varchar(20),
seccion varchar(20),
idAula int,
prerequisito int,
idPensum int,
idHorario int,
FOREIGN KEY (idAula) REFERENCES Aulas(idAula),
FOREIGN KEY (idPensum) REFERENCES Pensum(idPensum),
FOREIGN KEY (idHorario) REFERENCES Horarios(idHorario)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Telefonos(
idTelefono int not null,
PRIMARY KEY (idTelefono),
Telefono varchar(15)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table direcciones(
idDir int not null,
PRIMARY KEY (idDir),
Direccion varchar(50),
Departamento varchar (15),
Municipio varchar (15),
codPostal int
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Correos (
idCorreo int NOT NULL,
PRIMARY KEY (idCorreo),
Correo Varchar(20)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table catedratico (
idCat int NOT NULL,
PRIMARY KEY (idCat),
nombres Varchar(20),
apellidos Varchar(20),
dpi int,
idDir int,
idCorreo int,
idTel int,
FOREIGN KEY (idDir) REFERENCES direcciones(idDir),
FOREIGN KEY (idCorreo) REFERENCES Correos(idCorreo),
FOREIGN KEY (idTel) REFERENCES Telefonos(idTelefono)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Alumno (
idAlumno int NOT NULL,
PRIMARY KEY (idAlumno),
nombres Varchar(20),
Apellidos Varchar(20),
dpi int,
idDir int,
idCorreos int,
idTel int,
FOREIGN KEY (idDir) REFERENCES direcciones(idDir),
FOREIGN KEY (idCorreos) REFERENCES Correos(idCorreo),
FOREIGN KEY (idTel) REFERENCES Telefonos(idTelefono)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Carrera (
idCarrera int NOT NULL,
PRIMARY KEY (idCarrera),
idJornada int,
nombre Varchar(20),
idPensum int,
FOREIGN KEY (idJornada) REFERENCES Jornada(idJornada),
FOREIGN KEY (idPensum) REFERENCES Pensum(idPensum)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Facultades(
idFacultad int NOT NULL,
PRIMARY KEY (idFacultad),
nombre varchar(20),
idJornada int,
idCarrera int,
idPensum int,
FOREIGN KEY (idJornada) REFERENCES Jornada(idJornada),
FOREIGN KEY (idCarrera) REFERENCES Carrera(idCarrera),
FOREIGN KEY (idPensum) REFERENCES Pensum(idPensum)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table AsignacionCat(
idAsignacion int NOT NULL,
PRIMARY KEY (idAsignacion),
idCat int,
idCurso int,
FOREIGN KEY (idCat) REFERENCES catedratico(idCat),
FOREIGN KEY(idCurso) REFERENCES Cursos(idCurso)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1; 

Create Table AsignacionAlumno(
idAsignacion int NOT NULL,
PRIMARY KEY (idAsignacion),
idAlumno int,
idCurso int,
fecha date,
FOREIGN KEY (idAlumno) REFERENCES Alumno(idAlumno),
FOREIGN KEY(idCurso) REFERENCES Cursos(idCurso)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table sede(
idSede int not null,
nombre varchar(15),
idEdificio int,
PRIMARY KEY (idSede),
FOREIGN KEY (idEdificio) REFERENCES Edificio(idEdificio)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Tesoreia(
numBoleta int not null auto_increment,
PRIMARY KEY (numBoleta),
numtransaccion int null,
codMovimiento int not null,
total int not null,
idEstudiante int not null,
FOREIGN KEY (idEstudiante) REFERENCES Alumno(idAlumno)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Bitacora(
idBitacora int not null,
primary key(idBitacora),
descripccion varchar(50),
idUsuario int,
fecha datetime
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

create table certificacion(
idCertificacion int  not null,
primary key(idCertificacion),
idCurso int,
nota int,
FOREIGN KEY (idCurso) REFERENCES Cursos(idCurso)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;
