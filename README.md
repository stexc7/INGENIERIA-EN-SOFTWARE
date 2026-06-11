# INGENIERIA-EN-SOFTWARE

Allan Cardenas Montaño
index.html de inicio de pagina web de ropa

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
</head>

<body>
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container-fluid">
            <a class="navbar-brand" href="index.html">GhostStyle</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false"
                aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav ms-auto">
                    <li class="nav-item">
                        <a class="nav-link active" href="index.html">Inicio</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="producto.html">Producto</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="terminos.html">Terminos</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="contacto.html">Contacto</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <section class="container-mt 5 pt-5">
        <div class="row">
            <div class="col-12 text-center">
                <h1>Bienvenido a GhostStyle</h1>
                <p>Tu tienda de moda en línea</p>
            </div>
        </div>
    </section>

    <section class="container-my-5">
        <div id="carouseltienda" class="carousel slide" data-bs-ride="carousel">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#carouseltienda" data-bs-slide-to="0" class="active"
                    aria-current="true" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#carouseltienda" data-bs-slide-to="1"
                    aria-label="Slide 2"></button>
                <button type="button" data-bs-target="#carouseltienda" data-bs-slide-to="2"
                    aria-label="Slide 3"></button>
            </div>

                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="img/two.png" class="d-block w-235" alt="Ejemplo1">
                         <div class="carousel-caption d-none d-md-block">
                            <h5>
                                Diseños de camisetas online únicos y personalizados
                                <p>
                                Explora nuestra coleccion de diseños online exclusivos y personalizados
                                </p>
                            </h5>
                         </div>
                         </div>


                   
                    <div class="carousel-item">
                        <img src="img/ejemplobase.png" class="d-block w-235" alt="Ejemplo2">
                         <div class="carousel-caption d-none d-md-block">
                            <h5>
                                Diseños de camisetas online únicos y personalizados
                                <p>
                                Explora nuestra coleccion de diseños online exclusivos y personalizados
                                </p>
                            </h5>
                         </div>
                    
                    <div class="carousel-item">
                        <img src="img/ejemplo1.png" class="d-block w-235" alt="Ejemplo3">
                            <div class="carousel-caption d-none d-md-block">
                                <h5>
                                    Diseños de camisetas online únicos y personalizados
                                    <p>
                                    Explora nuestra coleccion de diseños online exclusivos y personalizados
                                    </p>
                                </h5>
                            </div>
                    </div>
                    
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouseltienda"
                    data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouseltienda"
                    data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
    </section>
    <footer class="bg-dark text-white py-4">
        <div class="container text-center">
            <p>&copy; GhostStyle Diseños de camisetas online 2025</p>
        </div>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>


</body>

</html>
