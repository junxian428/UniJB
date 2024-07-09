Source code from YouTube video: [How to implement Authorization in the Application Level (Clean Architecture)](https://www.youtube.com/watch?v=XH2hufRcJGc)



https://localhost:7170/api/auth/signin

{
    "email": "manager@manager.com",
    "password":"Pass123!"
}

{
    "success": true,
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImFiZDBjN2JjLTY4YjAtNGVhYy1iMDk1LTVlMTM0MjY1N2ExZCIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2VtYWlsYWRkcmVzcyI6Im1hbmFnZXJAbWFuYWdlci5jb20iLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoibWFuYWdlciIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6Ik1hbmFnZXIiLCJleHAiOjE3MDA3MjczNzksImlzcyI6IlRlc3QiLCJhdWQiOiJUZXN0In0.7xxrSc58ToDybVDDl9FvqsIgSSCbYz57g5kJWpSVzeE",
    "errors": []
}

![image](https://github.com/junxian428/Clean_Architecture_JWT_MySQL/assets/58724748/d4a67aec-ffd0-4fad-8a62-3da2e9a8c817)


After attached with Bear Token:

GET Request: https://localhost:7170/api/message/manager

Response :

Hello Manager

GET METHOD: https://localhost:7170/api/message/supervisor

Response:

Hello Supervisor

GET method: https://localhost:7170/api/message/admin

403 Forbidden

Admin Side:

https://localhost:7170/api/auth/signin


{
    "email": "admin@admin.com",
    "password":"Pass123!"
}

{
    "success": true,
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImNiNzNhZGE3LTJkMjMtNDhhNy05NDI5LWEyNGE1NDVjYjEyZSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2VtYWlsYWRkcmVzcyI6ImFkbWluQGFkbWluLmNvbSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJhZG1pbiIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkFkbWluIiwiZXhwIjoxNzAwNzI4MDgyLCJpc3MiOiJUZXN0IiwiYXVkIjoiVGVzdCJ9.6Ix6v5-g1jcABhFL4fIA3BRqa80ODkfhRiHGy6UKHRw",
    "errors": []
}

https://localhost:7170/api/message/admin

Response:

Only for Admins' Eyes
