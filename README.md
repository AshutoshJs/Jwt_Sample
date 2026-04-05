# Jwt_Sample

JWT has mainly 3 parts
1- Header
2- Payload
3- Signature

https://www.jwt.io/

![alt text](image.png)

eg. eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiYWRtaW4iOnRydWUsImlhdCI6MTUxNjIzOTAyMn0.KMUFsIDTnFmyG3nMiGM6H9FNFUROf3wh7SmqJp-QV30

1-header = eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9
2- payload = eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiYWRtaW4iOnRydWUsImlhdCI6MTUxNjIzOTAyMn0
3- signature = KMUFsIDTnFmyG3nMiGM6H9FNFUROf3wh7SmqJp-QV30

header part = {
  "alg": "HS256",
  "typ": "JWT"
}

payload = {
  "sub": "1234567890",
  "name": "John Doe",
  "admin": true,
  "iat": 1516239022
}

signature or SECRET = a-string-secret-at-least-256-bits-long

For token genration and validtion we use same secret

Payload Part:::what exactly paylaod is?
eg If I am admin user then token should have that conditon that I am admin although it is not mandatory but depends more on usecase it might be possible I need to use that information somewhere else so I will put that in paylaod part of JWT
one thing IMPORTANT about paylaod 
that it should not contain any kind of personal identifiable information because this token is exposed like in angualr or react you can open netowrk tab and see tokekn so no personal info

also paylaod is require to pass these values/ to have these common set of values so I do not need to make DB call again and again to check the user details 
