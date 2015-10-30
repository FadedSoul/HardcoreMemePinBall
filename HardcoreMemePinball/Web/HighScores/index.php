<?php
$servername = "localhost";
$username = "root"; //Hou dit op root
$password = "";
$dbname = "HighscoresDB"; //Deze bepaal jezelf! Let goed op,ja?

$name = $_GET['name'];
$score = $_GET['score'];

//Comment bijna alles uit, behalve de create table functie hieronder
//Dus houd Create connection en onderstaande sws aan.

/*$sql = "CREATE TABLE MyGuests (
id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
firstname VARCHAR(30) NOT NULL,
lastname VARCHAR(30) NOT NULL,
email VARCHAR(50),
reg_date TIMESTAMP
)";*/

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

//Hier douw je de waardes in de collommen die je boven maakte, 
//dat firstname, lastname word dus playername ofso
$sql = "INSERT INTO PlayerStats (PlayerName, Scores)
VALUES ('$name', '$score')";

if ($conn->query($sql) === TRUE) {
    //echo "New record created successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

//Read table in sql and order
$sql = "SELECT PlayerName, Scores FROM PlayerStats ORDER BY cast(Scores as Signed) DESC";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        echo "Name: " . $row["PlayerName"]. " " .$row["Scores"];
    }
} else {
    echo "0 results";
}

$conn->close();
?>