# Cookiecutter for AWS SAM and .NET

A Cookiecutter template to create a Serverless App based on Serverless Application Model (SAM) and .NET Core 2.1

> It is important to note that you should not try to `git clone` this project but use `cookiecutter` CLI instead as ``{{cookiecutter.project_slug}}`` will be rendered based on your input and therefore all variables and files will be rendered properly.

## Requirements

Install `cookiecutter` command line: 

**Pip users**:

* `pip install cookiecutter`

**Homebrew users**:

* `brew install cookiecutter`

**Windows or Pipenv users**:

* `pipenv install cookiecutter`

**NOTE**: [`Pipenv`](https://github.com/pypa/pipenv) is the new and recommended Python packaging tool that works across multiple platforms and makes Windows a first-class citizen.

## Usage

Generate a new SAM based Serverless App: `cookiecutter gh:aws-samples/cookiecutter-aws-sam-dotnet`. 

You'll be prompted a few questions to help this cookiecutter template to scaffold this project and after its completed you should see a new folder at your current path with the name of the project you gave as input.

**NOTE**: After you understand how cookiecutter works (cookiecutter.json, mainly), you can fork this repo and apply your own mechanisms to accelerate your development process and this can be followed for any programming language and OS.

## Options


Option | Description
------------------------------------------------- | ---------------------------------------------------------------------------------
`include_apigw` | Includes sample code for API Gateway Proxy integration for Lambda and a Catch All method in SAM as a starting point
`include_xray` | Includes both sample code for getting started with AWS X-Ray and adds necessary permission and `Tracing` to your function
`include_safe_deployment` | Sends by default 10% of traffic for every 1 minute to a newly deployed function using [CodeDeploy + SAM integration](https://github.com/awslabs/serverless-application-model/blob/master/docs/safe_lambda_deployments.rst) - Linear10PercentEvery1Minute

## Credits

* This project has been generated with [Cookiecutter](https://github.com/audreyr/cookiecutter)
* This project has been modelled on the [Cookiecutter SAM for Python Lambda functions](https://github.com/aws-samples/cookiecutter-aws-sam-python)

## License Summary

This sample code is made available under a modified MIT license. See the LICENSE file.
