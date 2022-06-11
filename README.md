# AWS SAM Cookiecutter for .NET Lambda functions

A Cookiecutter template to create a Serverless application using the AWS Serverless Application Model Command Line Interface (AWS SAM CLI) and .NET 6.

This template follows the default directory structure of Visual Studio solutions (including a test project).

> Do not `git clone` this project unless you want to fork it to create your own project template. To create a Serverless application from this template follow the instructions below and use the AWS SAM CLI instead.

## Requirements

### Cookiecutter install

Install `cookiecutter` command line:

* Pip users: `pip install cookiecutter`
* Homebrew users: `brew install cookiecutter`
* Windows or Pipenv users: `pipenv install cookiecutter`

### AWS SAM CLI install

To use the AWS SAM CLI, you need the following tools.

* AWS SAM CLI - [Install the AWS SAM CLI](https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/serverless-sam-cli-install.html)
* Docker - [Install Docker community edition](https://hub.docker.com/search/?type=edition&offering=community)

### Microsoft .NET 6 install

You will need the following for local testing.

* .NET 6.0 - [Install .NET 6.0](https://www.microsoft.com/net/download)

## Usage

The `sam init` command initializes a serverless application with an AWS SAM template, or a template or application you specify. Use the `location` parameter to pass the location of this project

```bash
sam init --location gh:aws-samples/cookiecutter-aws-sam-dotnet
```

alternatively you can use Cookiecutter command:

```bash
cookiecutter gh:aws-samples/cookiecutter-aws-sam-dotnet`. 
```

You'll be prompted a few questions to help this cookiecutter template to scaffold this project. After it's completed, you should see a new folder at your current path with the name of the project you specified as input.

> **NOTE**: After you understand how cookiecutter works (cookiecutter.json, mainly), you can fork this repo and apply your own mechanisms to accelerate your development process and this can be followed for any programming language and OS.

## Options

Option | Description
------------------------------------------------- | ---------------------------------------------------------------------------------|
`solution_name` | Name of the Visual Studio solution file |
`project_name` | Name of the Visual Studio project |
`include_safe_deployment` | Sends by default 10% of traffic for every 1 minute to a newly deployed function using [CodeDeploy + SAM integration](https://github.com/awslabs/serverless-application-model/blob/master/docs/safe_lambda_deployments.rst) - Linear10PercentEvery1Minute |

## Credits

* This project has been generated with [Cookiecutter](https://github.com/cookiecutter/cookiecutter)
* This project has been modelled on the [Cookiecutter SAM for Python Lambda functions](https://github.com/aws-samples/cookiecutter-aws-sam-python)

## License Summary

This sample code is made available under a modified MIT license. See the LICENSE file.
