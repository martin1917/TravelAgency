# TravelAgency

# ����� ����������

```mermaid
flowchart LR
    A[Client App] --> |http| B[API Gateway];
    B ---> |http| C[Auth / Users];
    B ---> |http| D[Tours / Requests];
    B ---> |http| E[Analytics];
    E ---> |http| D;
```

# �������� �����������
| name    | description| Details |
|---------|------------|---------|
| Client App | ���������� ���������� (GUI) | Windows Form |
| API Gateway | �����������, � �������� ���������� ���������� ���������� | ASP.NET + Ocelot | 
| Auth / Users | ������ �����������/����������� + �������� ���������� � ������������� | ASP.NET + JWT + EF|
| Tours / Requests | ������ �������� ����� � ������ �� ��� ���� | ASP.NET + JWT + EF|
| Analytics | ������ ��������� | ASP.NET + JWT|

# ����
| name    | description |
|-------|-------------|
| client | ������ |
| touragent | �������� |

# API Gateway
## auth (Auth / Users)
| method  | uri                                      | roles       | description|
|-------|:-----------------------------------------|:-----------:|------------|
| POST    | api/registrate                           | any         | ����������� �������
| POST    | api/auth                                 | any         | ����������� �������

## clients (Auth / Users)
| method  | uri                                      | roles       | description|
|-------|:-----------------------------------------|:-----------:|------------|
| GET     | api/clients                              | touragent   | �������� ���� ��������
| GET     | api/clients/{client_id}                  | touragent   | �������� ������� �� ID
| GET     | api/clients/me                           | client      | �������� ���� � ����
| UPDATE  | api/clients/me                           | client      | �������� ���� � ����

## tours (Tours / Requests)
| method  | uri                                      | roles       | description|
|-------|:-----------------------------------------|:-----------:|------------|
| GET     | api/tours                                | any         | �������� ��� ����
| GET     | api/tours/{tour_id}                      | any         | �������� ��� �� ID
| POST    | api/tours                                | touragent   | �������� ����� ���
| UPDATE  | api/tours/{tour_id}                      | touragent   | �������� ������ � ����
| DELETE  | api/tours/{tour_id}                      | touragent   | ������� ���

## requests (Tours / Requests)
| method  | uri                                      | roles       | description|
|-------|:-----------------------------------------|:-----------:|------------|
| GET     | api/requests/me?status={status}          | client      | �������� ��� ���� ������ � ������������ ��������
| GET     | api/requests?status={status}             | touragent   | �������� ��� ������ � ������������ ��������
| GET     | api/requests/{client_id}?status={status} | touragent   | �������� ��� ������ ������� �� ID � ������������ ��������
| POST    | api/requests                             | client      | ������� ������ �� ���
| POST    | api/requests/change_status               | touragent   | �������� ������ ������

## analytics (Analytics)
| method  | uri                                      | roles       | description|
|-------|:-----------------------------------------|:-----------:|------------|
| GET     | api/analytics/clients                    | touragent   | ���������� �� ���������� ��������� ����� � ����� ����������� ����� ��� ������� �������
| GET     | api/analytics/countries                  | touragent   | ���������� �� ���������� ��������� ����� � ����� ����������� ����� � ������ �� �����

# ������ ���������
## api/analytics/clients
| client_id | total_paid_tours | total_money_spent |
|:---:|:---:|:---:|
| 1 | 4 | 280000 |
| 2 | 3 | 185000 |
| ... |  |  |
| 18 | 1 | 105000 |

```mermaid
pie showData
    title ���������� �� ��������
    "������ � ID=1, ���. ����������� ����� = " : 280000
    "������ � ID=2, ���. ����������� ����� = " : 185000
    "������ � ID=18, ���. ����������� ����� = " : 105000
```

## api/analytics/countries
| country | total_paid_tours | total_profit |
|:---:|:---:|:---:|
| ������� | 30 | 675000 |
| ������ | 19 | 229000 |
| ... |  |  |
| ������� | 4 | 50000 |

```mermaid
pie showData
    title ���������� �� �������
    "�������, ����� = " : 675000
    "������, ����� = " : 229000
    "�������, ����� = " : 50000
```