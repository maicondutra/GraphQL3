# GraphQL3
Create a new repository GraphQL

https://rafaelcruz.azurewebsites.net/2017/02/20/graphql-construindo-graphql-api-em-net/

testar no postman

POST : http://localhost:60064/api/GraphQL

raw

{
    "Query": "query { human (id: \"1\") { name, homePlanet, appearsIn, friends { name }}}"
}
