#include <iostream>
#include <vector>
#include <string>
#include <iomanip>

using namespace std;

struct Producto
{
    int id;
    string nombre;
    double precio;
    int cantidad;
};

struct DetalleFactura
{
    string producto;
    int cantidad;
    double subtotal;
};

struct Factura
{
    int id;
    vector<DetalleFactura> detalles;
    double total;
};

vector<Producto> inventario;
vector<Factura> facturas;
int contadorProductos = 1;
int contadorFacturas = 1;

void agregarProducto()
{
    Producto p;
    p.id = contadorProductos++;
    cout << "\nNombre del producto: ";
    cin.ignore();
    getline(cin, p.nombre);
    cout << "Precio: ";
    cin >> p.precio;
    cout << "Cantidad en stock: ";
    cin >> p.cantidad;
    inventario.push_back(p);
    cout << "Producto agregado con ID: " << p.id << "\n";
}

void mostrarStock()
{
    cout << "\n--- Inventario ---\n";
    cout << left << setw(5) << "ID" << setw(20) << "Nombre" << setw(10) << "Precio" << "Stock\n";
    for (const auto&p : inventario) {
        cout << left << setw(5) << p.id << setw(20) << p.nombre << setw(10) << p.precio << p.cantidad << "\n";
    }
}

void generarFactura()
{
    Factura f;
    f.id = contadorFacturas++;
    f.total = 0;
    int idProd, cant;
    char continuar;

    cout << "\n--- Nueva Factura ---\n";
    do
    {
        cout << "ID del producto: ";
        cin >> idProd;
        cout << "Cantidad a vender: ";
        cin >> cant;

        bool encontrado = false;
        for (auto & p : inventario)
        {
            if (p.id == idProd)
            {
                encontrado = true;
                if (p.cantidad >= cant)
                {
                    p.cantidad -= cant;
                    double subtotal = p.precio * cant;
                    f.detalles.push_back({ p.nombre, cant, subtotal});
        f.total += subtotal;
        cout << "Agregado: " << cant << "x " << p.nombre << " - Subtotal: $" << subtotal << "\n";
    } else
    {
        cout << "Stock insuficiente. Stock actual: " << p.cantidad << "\n";
    }
    break;
}
        }
        if (!encontrado) cout << "Producto no encontrado.\n";

cout << "Agregar otro producto? (s/n): ";
cin >> continuar;
    } while (continuar == 's' || continuar == 'S') ;

if (!f.detalles.empty())
{
    facturas.push_back(f);
    cout << "Factura generada con exito. Total: $" << f.total << "\n";
}
else
{
    cout << "Factura vacia, no se guardo.\n";
    contadorFacturas--;
}
}

void mostrarFacturas()
{
    cout << "\n--- Registro de Facturas ---\n";
    for (const auto&f : facturas) {
        cout << "Factura ID: " << f.id << " | Total: $" << f.total << "\n";
for (const auto&d : f.detalles) {
    cout << "  - " << d.cantidad << "x " << d.producto << " ($" << d.subtotal << ")\n";
}
    }
}

int main()
{
    int opcion;
    do
    {
        cout << "\n1. Agregar Producto\n2. Ver Stock\n3. Generar Factura\n4. Ver Facturas\n5. Salir\nOpcion: ";
        cin >> opcion;

        switch (opcion)
        {
            case 1: agregarProducto(); break;
            case 2: mostrarStock(); break;
            case 3: generarFactura(); break;
            case 4: mostrarFacturas(); break;
            case 5: cout << "Saliendo...\n"; break;
            default: cout << "Opcion invalida.\n";
        }
    } while (opcion != 5);

    return 0;
}