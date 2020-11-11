# Poc-UserService

docker exec -it yourContainer mongo -u root -p


db.createUser(
   {
     user: "root",
     pwd: "example",  
     roles: [ "readWrite", "dbAdmin" ]
   }
)
