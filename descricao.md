M

O Modelo(Model) representa a lógica de negócios e os dados da aplicação. 
Ele encapsula a manipulação e a persistência dos dados, bem como as regras e a lógica de processamento.

Aqui criaremos as nossas Classes.

V

A Visão (View) é responsável pela apresentação da interface do usuário. 
Ela exibe os dados para o usuário de forma visualmente agradável e compreensível. 
A View é passiva e não realiza alterações diretas nos dados, apenas os exibe.
Ela também pode capturar as interações do usuário e enviá-las para o Controller.

Aqui iremos interagir com o usuário.

C

Controlador (Controller): O Controlador atua como intermediário entre o Modelo e a Visão. 
Ele recebe as interações do usuário vindas da Visão e as traduz em ações no Modelo.
Ele também é responsável por atualizar a Visão com os dados mais recentes do Modelo.

Aqui realizaremos as tratativas dos dados vindos da View e instanciaremos os objetos(se necessário).

R

Normalmente ele fica dentro do Model, porém, para adicionar uma outra camada de manipulação e também 
separação de responsabilidades, criaremos também um repository.

Aqui criaremos a nossa List