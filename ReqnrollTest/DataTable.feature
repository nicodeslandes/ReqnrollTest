﻿Feature: Test Data Table

A short summary of the feature

Scenario: Data Table can have a comment trailing its definition
	Then the data should be
	| Id | Value   |
	| 1  | Charlie | # Initial Value

Scenario: Data Table can have a comment trailing its definition with a Note header
	Then the data should be
	| Id | Value   | Notes
	| 1  | Charlie | Initial Value
