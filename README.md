# Kubernetes Multi-Tier Application Assignment

## Repository

GitHub Repository:
<YOUR_GITHUB_REPO_URL>

## Docker Images

Docker Hub Repository:
<YOUR_DOCKER_HUB_URL>

Example:

https://hub.docker.com/r/arjunbyahut/employee-api

## Application URL

Employee API Endpoint:

http://<INGRESS-IP>/api/employees

## Project Structure

* ASP.NET Core Employee API
* PostgreSQL Database
* Kubernetes Deployment
* StatefulSet
* Service
* ConfigMap
* Secret
* PVC
* Ingress
* HPA

## Kubernetes Manifests

The repository contains:

* namespace.yaml
* configmap.yaml
* secret.yaml
* postgres-statefulset.yaml
* postgres-service.yaml
* api-deployment.yaml
* api-service.yaml
* ingress.yaml
* hpa.yaml

## Screen Recording

Video Demonstrates:

* All Kubernetes resources deployed
* API retrieving records from database
* Self-healing of API pods
* Database pod recovery
* Data persistence after pod recreation
* Rolling updates
* Horizontal Pod Autoscaler
* FinOps considerations

## Verification Commands

kubectl get pods -n assignment

kubectl get svc -n assignment

kubectl get ingress -n assignment

kubectl get pvc -n assignment

kubectl get hpa -n assignment
