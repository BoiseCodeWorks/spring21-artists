/* MSSQL BAD : MYSQL GOOD */

/* CREATING TABLES */
-- CREATE TABLE artists_mark (
--   id INT NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL,
--   birthyear INT NOT NULL,
--   deathyear INT,

--   PRIMARY KEY (id)
-- );

/* ADD DATA TO TABLE */

-- INSERT INTO artists
-- (name, birthyear, deathyear)
-- VALUES
-- ("Vincent van Gogh", 1853, 1890);
-- INSERT INTO artists
-- (name, birthyear, deathyear)
-- VALUES
-- ("Monet", 1840, 1926);

-- INSERT INTO artists
-- (name, birthyear, deathyear)
-- VALUES
-- ("Leonardo da Vinci", 1492, 1519);
-- INSERT INTO artists
-- (name, birthyear, deathyear)
-- VALUES
-- ("Michelangelo di Lodovico Buonarroti Simoni", 1475, 1564);


/* GETTING DATA FROM TABLES */
/* SELECT {columns} FROM {table} WHERE {query}*/

/* GetALL */
/* SELECT * FROM artists; */


/* GetById */
/* SELECT * FROM artists WHERE birthyear > 1500 AND deathyear < 1900; */


/* EDIT/UPDATE */
/* UPDATE artists
SET
  name = "Michelangelo"
WHERE id = 4; */
/* SELECT * FROM artists WHERE id = 4; */


/* DELETE */
/* DELETE FROM artists WHERE id = 3; */

/* SELECT * FROM artists; */



/* !!!! DANGER ZONE !!!! */
/* REMOVE ALL DATA FROM TABLE */
/* DELETE FROM artists; */

/* DELETE ENTIRE TABLE */
/* DROP TABLE artists */

/* DELETE ENTIRE DATABASE */
/* DROP DATABASE; */
