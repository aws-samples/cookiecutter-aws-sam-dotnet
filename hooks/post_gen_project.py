from __future__ import print_function

TERMINATOR = "\x1b[0m"
INFO = "\x1b[1;33m [INFO]: "
SUCCESS = "\x1b[1;32m [SUCCESS]: "
HINT = "\x1b[3;33m"


def main():
    solution_name = '{{ cookiecutter.solution_name }}'

    print(SUCCESS +
          "Project initialized successfully! You can now jump to {} folder".
          format(solution_name) + TERMINATOR)
    print(INFO +
          "{}/README.md contains instructions on how to proceed.".
          format(solution_name) + TERMINATOR)


if __name__ == '__main__':
    main()
