“In a supervision hierarchy, keep important application state or functionality near the root while delegating risky operations towards the leaves.”

This pattern builds on the Simple Component pattern and is applicable wherever components with different failure probability and reliability requirements are combined into a larger system or application—some functions of the system must never go down, whereas others are necessarily exposed to failure. Applying the Simple Component pattern will frequently leave you in this position, so it pays to familiarize yourself well with the Error Kernel pattern.

This pattern has been established in Erlang programs for decades and was one of the main inspirations for Jonas Bonér to implement an Actor framework—Akka—on the JVM. The name Akka was originally conceived as a palindrome of Actor Kernel, referring to this core design pattern.
